
import { InwardEntryComponent } from './outer-module/sidenav/inward-entry/inward-entry.component';
import { RMPMComponent } from './outer-module/sidenav/rm-pm/rm-pm.component';
import { WmComponent } from './outer-module/sidenav/wm/wm.component';
import { AqaComponent } from './outer-module/sidenav/aqa/aqa.component';
import { DispensingComponent } from './outer-module/sidenav/dispensing/dispensing.component';
import { CalibrationComponent } from './outer-module/sidenav/calibration/calibration.component';
import { WipComponent } from './outer-module/sidenav/wip/wip.component';
import { FinishGoodsComponent } from './outer-module/sidenav/finish-goods/finish-goods.component';
import { ContainerMasterComponent } from './outer-module/sidenav/container-master/container-master.component';
import { ReprintComponent } from './outer-module/sidenav/reprint/reprint.component';
import { HdpeComponent } from './outer-module/sidenav/hdpe/hdpe.component';
import { MaterialTrackingComponent } from './outer-module/sidenav/material-tracking/material-tracking.component';
import { StatusLabelPrintingComponent } from './outer-module/sidenav/rm-pm/status-label-printing/status-label-printing.component'

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { HomeComponent } from './components/home/home.component';
import { AuthGuard } from 'src/app/components/auth.guard';
import { OuterModuleModule } from './outer-module/outer-module.module';

const routes: Routes = [
  {
    path: '',
    component: AdminDashboardComponent,
    canActivate: [AuthGuard],
    children: [
      { path: 'home', component: HomeComponent },
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'InwardEntry', component: InwardEntryComponent },
      { path: 'rm-pm', component: RMPMComponent },
      { path: 'wm', component: WmComponent },
      { path: 'aqa', component: AqaComponent },
      { path: 'dispensing', component: DispensingComponent },
      { path: 'calibration', component: CalibrationComponent },
      { path: 'wip', component: WipComponent },
      { path: 'FinishedGoods', component: FinishGoodsComponent },
      { path: 'ContainerMaster', component: ContainerMasterComponent },
      { path: 'Reprint', component: ReprintComponent },
      { path: 'hdpe', component: HdpeComponent },
      { path: 'materialTracking', component: MaterialTrackingComponent },
      //Rm/Pm Childs
      { path: 'statuslabelprinting', component: StatusLabelPrintingComponent }
      
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes),OuterModuleModule],
  exports: [RouterModule,OuterModuleModule],

})
export class AdminRoutingModule { }
