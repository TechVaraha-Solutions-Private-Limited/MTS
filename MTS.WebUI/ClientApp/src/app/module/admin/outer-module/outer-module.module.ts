import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { InwardEntryComponent } from './sidenav/inward-entry/inward-entry.component';
import { WmComponent } from './sidenav/wm/wm.component';
import { DispensingComponent } from './sidenav/dispensing/dispensing.component';
import { CalibrationComponent } from './sidenav/calibration/calibration.component';
import { WipComponent } from './sidenav/wip/wip.component';
import { FinishGoodsComponent } from './sidenav/finish-goods/finish-goods.component';
import { ContainerMasterComponent } from './sidenav/container-master/container-master.component';
import { ReprintComponent } from './sidenav/reprint/reprint.component';
import { HdpeComponent } from './sidenav/hdpe/hdpe.component';
import { MaterialTrackingComponent } from './sidenav/material-tracking/material-tracking.component';
import { AqaComponent } from './sidenav/aqa/aqa.component';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import { RMPMComponent } from './sidenav/rm-pm/rm-pm.component';
import { StatusLabelPrintingComponent } from './sidenav/rm-pm/status-label-printing/status-label-printing.component'; 
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
  
    SidenavComponent,
       AqaComponent,
       InwardEntryComponent,
       WmComponent,
       DispensingComponent,
       CalibrationComponent,
       WipComponent,
       FinishGoodsComponent,
       ContainerMasterComponent,
       ReprintComponent,
       HdpeComponent,
       MaterialTrackingComponent,
       AqaComponent,
       RMPMComponent,
    StatusLabelPrintingComponent,
    
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule,
    FormsModule,
    RouterModule,
    HttpClientModule

  ],
  exports: [
    MaterialTrackingComponent,
    FormsModule,
    MatCardModule,
    MatIconModule,
    RouterModule,
    HttpClientModule
  ]
})
export class OuterModuleModule { }
