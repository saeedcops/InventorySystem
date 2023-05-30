import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import {  MatSidenavModule } from '@angular/material/sidenav';
import { MatDividerModule } from '@angular/material/divider';
import { ItemsComponent } from './items/items.component';
import { ItemAddEditComponent } from './items/item-add-edit/item-add-edit.component';
import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ErrorInterceptor } from './core/interceptor/error.interceptor';
import { LoadingInterceptor } from './core/interceptor/loading.interceptor';
import { JwtInterceptor } from './core/interceptor/jwt.interceptor';
import { AccountModule } from './account/account.module';
import { RouterModule } from '@angular/router';
import { CoreModule } from './core/core.module';
import { HomeModule } from './home/home.module';
import { MatFormFieldModule, MatHint } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { ReactiveFormsModule } from '@angular/forms';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { ItemTypesComponent } from './item-types/item-types.component';
import { CustomersComponent } from './customers/customers.component';
import { BrandsComponent } from './brands/brands.component';
import { EngineersComponent } from './engineers/engineers.component';
import { ItemTypesAddEditComponent } from './item-types/item-types-add-edit/item-types-add-edit.component';
import { OrdersComponent } from './orders/orders.component';
import { WarehouseComponent } from './warehouse/warehouse.component';
import { WarehouseAddEditComponent } from './warehouse/warehouse-add-edit/warehouse-add-edit.component';
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    ItemsComponent,
    ItemAddEditComponent,
    ItemTypesAddEditComponent,
    ItemTypesComponent,
    CustomersComponent,
    BrandsComponent,
    EngineersComponent,
    OrdersComponent,
    WarehouseComponent,
    WarehouseAddEditComponent
    
  ],
  imports: [
    //BrowserModule,
    //AppRoutingModule,
    //BrowserAnimationsModule,
    //MatToolbarModule,
    //MatIconModule,
    //MatButtonModule,
    //MatDialogModule,
    //MatFormFieldModule,
    //MatInputModule,
    //MatDatepickerModule,
    //MatNativeDateModule,
    //MatRadioModule,
    //MatSelectModule,
    //ReactiveFormsModule,
    //MatDividerModule,
    //MatTableModule,
    //MatPaginatorModule,
    //MatSidenavModule,
    //MatSortModule,
    //MatSnackBarModule,
    //HttpClientModule,
    //RouterModule,
    AccountModule,
    CoreModule,
    HomeModule,
    SharedModule
    
   // BreadcrumbModule
  ],
  providers: [MatDialogModule,
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
