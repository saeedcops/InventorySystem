import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSidenavModule } from '@angular/material/sidenav';
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
import { BreadcrumbModule } from 'xng-breadcrumb';

@NgModule({
  declarations: [
    AppComponent,
    ItemsComponent,
    ItemAddEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatSidenavModule,
    MatDividerModule,
    HttpClientModule,
    RouterModule,
    AccountModule,
    CoreModule,
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
