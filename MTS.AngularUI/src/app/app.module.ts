// CommonModule
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

// import Modules
import { HttpClientModule } from '@angular/common/http';
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { AppRoutingModule } from './app-routing.module';
import { MockApiService } from './mock-api.service';
import { CommonModule } from '@angular/common';
import {MatSidenavModule} from '@angular/material/sidenav'; 
import {MatFormFieldModule} from '@angular/material/form-field'; 
import {MatSelectModule} from '@angular/material/select'; 
import {FormsModule} from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {NgFor} from '@angular/common';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button'; 
import { ReactiveFormsModule } from '@angular/forms';
import { AdminModule } from './module/admin/admin.module';
import { InnerModuleModule } from './module/admin/outer-module/inner-module/inner-module.module';
import { OuterModuleModule } from './module/admin/outer-module/outer-module.module';



// Import Components
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { AdminDashboardComponent } from './module/admin/components/admin-dashboard/admin-dashboard.component';
import { FooterComponent } from './module/admin/components/footer/footer.component';
import { HeaderComponent } from './module/admin/components/header/header.component';
import { HomeComponent } from './module/admin/components/home/home.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NotFoundComponent,
    AppComponent,
    AdminDashboardComponent,
    FooterComponent,
    HeaderComponent,
    HomeComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    HttpClientInMemoryWebApiModule.forRoot(MockApiService),
    MatSidenavModule,
    MatFormFieldModule,
    MatSelectModule,
    FormsModule,
    MatInputModule,
    NgFor,
    MatCardModule,
    MatButtonModule,
    ReactiveFormsModule,
    CommonModule,
    AdminModule,
    InnerModuleModule ,
    OuterModuleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
