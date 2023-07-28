import { Component } from '@angular/core';

@Component({
  selector: 'app-status-label-printing',
  templateUrl: './status-label-printing.component.html',
  styleUrls: ['./status-label-printing.component.css']
})
export class StatusLabelPrintingComponent {
 
  printerStatus: boolean = false; // Initial state, assuming the printer is offline

  togglePrinterStatus() {
    this.printerStatus = !this.printerStatus
  }
  toggleclose() {
    this.printerStatus= false;
  }
  printers = [
    { id: 1, name: "printer1" }, { id: 1, name: "Printer2" }, { id: 1, name: "Printer3" }
  ]
  /*defaultselect=*/
  printval: string = '';
  getData(temp:any) {
    this.printval = temp.value;
  }

  defaultselect1:any = '';
}
