import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatToolbarModule} from '@angular/material/toolbar'; 
import {MatIconModule} from '@angular/material/icon'; 
import {MatListModule} from '@angular/material/list'; 
import {MatSidenavModule} from '@angular/material/sidenav'; 
import {MatFormFieldModule} from '@angular/material/form-field'; 
import {MatSelectModule} from '@angular/material/select'; 
import {FormsModule} from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {NgFor} from '@angular/common';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button'; 
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
   
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatFormFieldModule,
    MatSelectModule,
    FormsModule,
    MatInputModule,
    NgFor,
    MatCardModule,
    MatButtonModule,
    ReactiveFormsModule,
   

  ],
  exports:[
    MatToolbarModule,
    MatIconModule,
    MatListModule,
    MatSidenavModule,
    MatFormFieldModule,
    MatSelectModule,
    FormsModule,
    MatInputModule,
    NgFor,
    MatCardModule,
    MatButtonModule,
    ReactiveFormsModule,

  ]
})
export class MaterialsModule { }
