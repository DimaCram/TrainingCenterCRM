export class Student {
    password: string;
    email: string;
    constructor(
    public id: number,
    public name: string,
    public surname: string,
    public age: number
    ) {}
}