import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ItemsComponent } from './items/items.component';
import { OrdersComponent } from './orders/orders.component';
import { PartsComponent } from './parts/parts.component';
import { ReportsComponent } from './reports/reports.component';
import { SupplyOrdersComponent } from './supply-orders/supply-orders.component';
import { UsersComponent } from './users/users.component';

const routes: Routes = [
  { path: '', component: HomeComponent, data: { breadcrumb: 'Home' } },
  { path: 'items', component: ItemsComponent, data: { breadcrumb: 'Items' } },
  { path: 'orders', component: OrdersComponent, data: { breadcrumb: 'Orders' } },
  { path: 'parts', component: PartsComponent, data: { breadcrumb: 'Parts' } },
  { path: 'reports', component: ReportsComponent, data: { breadcrumb: 'Reports' } },
  { path: 'users', component: UsersComponent, data: { breadcrumb: 'Users' } },
  { path: 'supply-orders', component: SupplyOrdersComponent, data: { breadcrumb: 'supply-orders' } },
  { path: 'account', loadChildren: () => import('./account/account.module').then(mod => mod.AccountModule), data: { breadcrumb: { skip: true } } },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
