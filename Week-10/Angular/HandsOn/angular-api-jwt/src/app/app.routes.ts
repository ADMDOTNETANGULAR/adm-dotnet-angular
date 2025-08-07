import { Routes } from '@angular/router';
import { Login } from './login/login';
import { ViewProducts } from './view-products/view-products';
import { AdminDashboard } from './admin-dashboard/admin-dashboard';
import { UserDashboard } from './user-dashboard/user-dashboard';


export const routes: Routes = [
    { path: 'login', component: Login },
    {
        path: 'admin-dashboard', component: AdminDashboard, children: [
            { path: 'view-products', component: ViewProducts },
            { path: 'add-product', component: ViewProducts },
            { path: 'edit-product', component: ViewProducts },
        ]
    },
    {
        path: 'user-dashboard', component: UserDashboard, children: [
            { path: 'view-products', component: ViewProducts },
            { path: 'edit-profile', component: ViewProducts },
            { path: 'view-cart', component: ViewProducts },
            { path: 'view-orders', component: ViewProducts },
            { path: 'view-payments', component: ViewProducts }
        ]
    },
];
