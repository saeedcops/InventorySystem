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
    CdkStepperModule,
    RouterModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatSidenavModule,
    MatDividerModule,
    
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
    CdkStepperModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatSidenavModule,
    MatDividerModule,
    //StepperComponent,
    //BasketSummaryComponent
  ]
})
export class SharedModule { }
