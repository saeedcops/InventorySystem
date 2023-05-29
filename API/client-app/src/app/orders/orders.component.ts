import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ItemService } from '../items/item.service';
import { OrdersService } from './orders.service';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent implements OnInit {

  constructor(private orderService: OrdersService) { }

  ngOnInit(): void {
    this.Addnewrow();
  }

  title = 'FormArray';
  items!: FormArray;
  reactform = new FormGroup({
    customerId: new FormControl('', Validators.required),
    engineerId: new FormControl('', Validators.required),
    orderType: new FormControl('', Validators.required),
    orderItemsPartNumber: new FormArray([])
  });

  ProceedSave() {
    console.log(this.reactform.value);
    if (this.reactform.valid)
      this.orderService.addOrder(this.reactform.value).subscribe(res => {
        console.log(res);
      }, er => {
        console.log(er);
      });
  }

  Addnewrow() {
    this.items = this.reactform.get("orderItemsPartNumber") as FormArray;
    this.items.push(this.Genrow())
  }
  Removeitem(index: any) {
    this.items = this.reactform.get("orderItemsPartNumber") as FormArray;
    this.items.removeAt(index)
  }

  get deladdress() {
    return this.reactform.get("orderItemsPartNumber") as FormArray;
  }

  Genrow(): FormGroup {
    return new FormGroup({
      count: new FormControl('', Validators.required),
      partNumber: new FormControl('', Validators.required)
    });
  }


}
