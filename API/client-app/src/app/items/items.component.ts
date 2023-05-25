import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ItemService } from './item.service';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.scss']
})
export class ItemsComponent implements OnInit{

  constructor(private _matDialog: MatDialog, private _itemService: ItemService) { }

    ngOnInit(): void {
     
    }
  loadItems() {
    this._itemService.getItems();
  }
  openDialog() {
    this._matDialog.open(ItemsComponent);
  }
}
