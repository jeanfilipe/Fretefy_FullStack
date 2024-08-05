import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { RegiaoComponent } from './regiao.component';

@NgModule({
  declarations: [
    RegiaoComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [
    RegiaoComponent
  ]
})
export class RegiaoModule { }
