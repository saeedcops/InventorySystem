import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
//import { PaginationModule } from 'ngx-bootstrap/pagination';
//import { CarouselModule } from 'ngx-bootstrap/carousel';
//import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
//import { PagerComponent } from './components/pager/pager.component';
//import { OrderTotalsComponent } from './components/order-totals/order-totals.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CdkStepperModule } from '@angular/cdk/stepper';
//import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
//import { TextInputComponent } from './components/text-input/text-input.component';
//import { StepperComponent } from './components/stepper/stepper.component';
//import { BasketSummaryComponent } from './components/basket-summary/basket-summary.component';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatDividerModule } from '@angular/material/divider';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    //PagingHeaderComponent,
    //PagerComponent,
    //OrderTotalsComponent,
    //TextInputComponent,
    //StepperComponent,
    //BasketSummaryComponent
  ],
  imports: [
    CommonModule,
    //PaginationModule.forRoot(),
    //CarouselModule.forRoot(),
    //BsDropdownModule.forRoot(),
    ReactiveFormsModule,
    //CdkStepperModule,
    //RouterModule,
    //MatToolbarModule,
    //MatIconModule,
    //MatButtonModule,
    //MatDialogModule,
    //MatSidenavModule,
    //MatDividerModule,

    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatRadioModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatDividerModule,
    MatTableModule,
    MatPaginatorModule,
    MatSidenavModule,
    MatSortModule,
    MatSnackBarModule,
    HttpClientModule,
    RouterModule,
    
  ],
  exports: [
    //PaginationModule,
    //PagingHeaderComponent,
    //PagerComponent,
    //CarouselModule,
    //OrderTotalsComponent,
    ReactiveFormsModule,
    //BsDropdownModule,
    //TextInputComponent,
    //CdkStepperModule,
    //MatToolbarModule,
    //MatIconModule,
    //MatButtonModule,
    //MatDialogModule,
    //MatSidenavModule,
    //MatDividerModule,
    //StepperComponent,
    //BasketSummaryComponent

    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatRadioModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatDividerModule,
    MatTableModule,
    MatPaginatorModule,
    MatSidenavModule,
    MatSortModule,
    MatSnackBarModule,
    HttpClientModule,
    RouterModule,
  ]
})
export class SharedModule { }
