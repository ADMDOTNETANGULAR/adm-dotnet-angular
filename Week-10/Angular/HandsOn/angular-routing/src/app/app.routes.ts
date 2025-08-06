import { Routes } from '@angular/router';
import { Home } from './home/home';
import { About } from './about/about';
import { Contact } from './contact/contact';
import { Courses } from './courses/courses';

//define the routes for the application
export const routes: Routes = [
    { path: 'home', component: Home },
    { path: 'about', component: About },
    { path: 'contact', component: Contact },
    { path: 'courses', component: Courses },
    { path: '', redirectTo: 'home', pathMatch: 'full' }
];
