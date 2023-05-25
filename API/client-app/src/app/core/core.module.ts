import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
//import { NavBarComponent } from './nav-bar/nav-bar.component';
import { RouterModule } from '@angular/router';
//import { TestErrorComponent } from './test-error/test-error.component';
//import { NotFoundComponent } from './not-found/not-found.component';
//import { ServerErrorComponent } from './server-error/server-error.component';
//import { ToastrModule } from 'ngx-toastr';
//import { SectionHeaderComponent } from './section-header/section-header.component';
import { BreadcrumbModule } from 'xng-breadcrumb';
import { SharedModule } from '../shared/shared.module';
import { SectionHeaderComponent } from './section-header/section-header.component';
import { SideBarComponent } from './side-bar/side-bar.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatDividerModule } from '@angular/material/divider';
//TestErrorComponent, NotFoundComponent, ServerErrorComponent

@NgModule({
  declarations: [/*NavBarComponent, TestErrorComponent, NotFoundComponent, ServerErrorComponent, SectionHeaderComponent*/
    SectionHeaderComponent, SideBarComponent
  ],
  exports: [SideBarComponent, SectionHeaderComponent],
  imports: [
    CommonModule,
    RouterModule,
    BreadcrumbModule,
    SharedModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatSidenavModule,
    MatDividerModule,
    //ToastrModule.forRoot({
    //  positionClass: 'toast-bottom-right',
    //  preventDuplicates: true
    //})
  ]
})
export class CoreModule { }
