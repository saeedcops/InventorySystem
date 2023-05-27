import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ItemAddEditComponent } from './item-add-edit/item-add-edit.component';
import { ItemService } from './item.service';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.scss']
})
export class ItemsComponent implements OnInit{

  constructor(private _matDialog: MatDialog, private _itemService: ItemService) { }

  loadItems() {
    this._itemService.getItems();
  }
  openDialog() {
    this._matDialog.open(ItemAddEditComponent);
  }


  displayedColumns: string[] = [
    'brand',
    'description',
    'itemStatus',
    'itemType',
    'model',
    'oracleCode',
    'partNumber',
    'serialNumber',
    'warehouse',
  ];

  dataSource!: MatTableDataSource<any>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;


  ngOnInit(): void {
    this.getEmployeeList();
  }

  openAddEditItemForm() {

    const dialogRef = this._matDialog.open(ItemAddEditComponent);
    dialogRef.afterClosed().subscribe({
      next: (val) => {
        if (val) {
          this.getEmployeeList();
        }
      },
    });
  }

  getEmployeeList() {
    this._itemService.getItems().subscribe({
      next: (res:any) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
        console.log(res.items);
      },
      error: console.log,
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  deleteEmployee(id: number) {
    //this._empService.deleteEmployee(id).subscribe({
    //  next: (res) => {
    //    this._coreService.openSnackBar('Employee deleted!', 'done');
    //    this.getEmployeeList();
    //  },
    //  error: console.log,
    //});
  }

  openEditForm(data: any) {
    const dialogRef = this._matDialog.open(ItemAddEditComponent, {
      data,
    });

    dialogRef.afterClosed().subscribe({
      next: (val) => {
        if (val) {
          this.getEmployeeList();
        }
      },
    });
  }
}
