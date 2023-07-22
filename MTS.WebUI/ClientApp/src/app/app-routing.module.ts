import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from './components/login/login.component';
import { AdminModule } from './module/admin/admin.module';

const routes: Routes = [
  {path:'Login',component:LoginComponent},
  {path: '', redirectTo:'/Login', pathMatch: 'full' },
  {path:'admin',loadChildren:()=>
  import ( "./module/admin/components/admin-dashboard/admin-dashboard.component").then((m)=>AdminModule)},
];

@NgModule({
  imports: [RouterModule.forRoot(routes),
],

  exports: [RouterModule,
   ]
})
export class AppRoutingModule { }
