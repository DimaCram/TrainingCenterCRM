window.addEventListener('DOMContentLoaded', event => {

    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    const sidebar = document.body.querySelector('#sidebar-wrapper');
    if (sidebarToggle) {
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            sidebar.classList.toggle('sidenav-toggled');
        });
    }
});