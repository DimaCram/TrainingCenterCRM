import { Route } from "@angular/compiler/src/core";
import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlSegment, UrlTree } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { Observable, ObservableLike } from "rxjs";
import { AccountService } from "src/app/services/account.service";

@Injectable({providedIn: "root"})
export class AuthGuard implements CanActivate{
    constructor(private jwtHelper: JwtHelperService,
                private authService: AccountService,
                private router: Router){}

      canActivate(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Promise<boolean | UrlTree> | boolean | UrlTree {
        let url: string = state.url;
        return this.checkUserLogin(next, url);
      }
      canActivateChild(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        return this.canActivate(next, state);
      }
      canDeactivate(
        component: unknown,
        currentRoute: ActivatedRouteSnapshot,
        currentState: RouterStateSnapshot,
        nextState?: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        return true;
      }
      canLoad(
        route: Route,
        segments: UrlSegment[]): Observable<boolean> | Promise<boolean> | boolean {
        return true;
      }

      checkUserLogin(route: ActivatedRouteSnapshot, url: any): boolean {
        const token = localStorage.getItem("jwt");
        if(token && !this.jwtHelper.isTokenExpired(token)){
          const userRole = this.authService.getRole();
          if (route.data.role && route.data.role.indexOf(userRole) === -1) {
            this.router.navigate(['/error', 401]);
            return false;
          }
          return true;
        }

        this.router.navigate(['/login']);
        return false;
      }
}