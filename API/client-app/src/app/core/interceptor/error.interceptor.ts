import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { catchError, delay, Observable, throwError } from 'rxjs';
import { NavigationExtras, Router } from '@angular/router';
//import { ToastrService } from 'ngx-toastr';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router: Router, /*private toastr: ToastrService*/) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(

      catchError(error => {
        if (error) {
          if (error.status === 400) {
            if (error.error.errors) {
              throw error.error
            } else {
              console.log(error.error.massage);
             // this.toastr.error(error.error.massage, error.error.statusCode);

            }
          }

          if (error.status === 401) {
            //this.toastr.error(error.error.massage, error.error.statusCode);
            console.log(error.error.massage);


          }

          if (error.status === 404) {
           // this.router.navigateByUrl('/not-found');
          }

          if (error.status === 500) {
            //const navigation: NavigationExtras = { state: { error: error.error } };
           // this.router.navigateByUrl('/server-error', navigation);
            console.log(error.error.massage);

          }
        }
        return throwError(error);
      })
    );
  }
}
