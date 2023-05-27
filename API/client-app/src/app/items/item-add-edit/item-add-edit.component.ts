import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ItemService } from '../item.service';

@Component({
  selector: 'app-item-add-edit',
  templateUrl: './item-add-edit.component.html',
  styleUrls: ['./item-add-edit.component.scss']
})
export class ItemAddEditComponent implements OnInit {
  empForm: FormGroup;

  education: string[] = [
    'Matric',
    'Diploma',
    'Intermediate',
    'Graduate',
    'Post Graduate',
  ];


  constructor(
    private _fb: FormBuilder,
    private _itemService: ItemService,
    private _dialogRef: MatDialogRef<ItemAddEditComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) {
    this.empForm = this._fb.group({

      partNumber:'',
      oracleCode:'',
      warehouseCode:'',
      name: '',
      model:  '',
      description:  '',
      itemTypeId:   '',
      brandId:'',
      warehouseId:  '',
      image: '',
    });

  }

  ngOnInit(): void {
    this.empForm.patchValue(this.data);
  }

  onFormSubmit() {
    if (this.empForm.valid) {
      if (this.data) {
        this._itemService
          .getItems()
          .subscribe({
            next: (val: any) => {
              //this._coreService.openSnackBar('Employee detail updated!');
              this._dialogRef.close(true);
              console.error(val);
            },
            error: (err: any) => {
              console.error(err);
            },
          });
      } else {
        this._itemService.addItems(this.empForm.value).subscribe({
          next: (val: any) => {
            //this._coreService.openSnackBar('Employee added successfully');
            this._dialogRef.close(true);
            console.error(val);
          },
          error: (err: any) => {
            console.error(err);
          },
        });
      }
    }
  }
}
