import { Routes } from '@angular/router';
import { Login } from './login/login';
import { Dashboard } from './dashboard/dashboard';
import { AuthGuard } from './auth.guard';

export const routes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'login', component: Login },
    { path: 'dashboard', component: Dashboard, canActivate: [AuthGuard] },
    { path: '**', redirectTo: '/login' }
];
