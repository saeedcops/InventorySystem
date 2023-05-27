import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, map, of, ReplaySubject } from 'rxjs';
import { environment } from '../../environments/environment';
import { IItemPagination } from '../shared/models/item';
import { IUser } from '../shared/models/user';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  baseUrl = environment.apiUrl;
  user!: IUser;
  private userSource = new ReplaySubject<IUser>(1);

  user$ = this.userSource.asObservable();

  constructor(private http: HttpClient, private router: Router) { }


  getItems() {

    return this.http.get(this.baseUrl + 'items');
  }

  addItems(data: any) {
    

    return this.http.post(this.baseUrl + 'items',data);
  }
}
