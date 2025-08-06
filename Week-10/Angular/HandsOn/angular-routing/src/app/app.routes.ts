import { Routes } from '@angular/router';
import { Home } from './home/home';
import { About } from './about/about';
import { Contact } from './contact/contact';
import { Courses } from './courses/courses';
import { Pagenotfound } from './pagenotfound/pagenotfound';
import { Login } from './login/login';
import { AdminDashboard } from './admin-dashboard/admin-dashboard';
import { CustomerDashboard } from './customer-dashboard/customer-dashboard';

//define the routes for the application
export const routes: Routes = [
    { path: 'home', component: Home },
    { path: 'about', component: About },
    { path: 'contact', component: Contact },
    { path: 'courses', component: Courses },
    { path: 'login', component: Login },
    { path: 'admin-dashboard', component: AdminDashboard },
    { path: 'customer-dashboard', component: CustomerDashboard },
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: '**', component: Pagenotfound }
];
