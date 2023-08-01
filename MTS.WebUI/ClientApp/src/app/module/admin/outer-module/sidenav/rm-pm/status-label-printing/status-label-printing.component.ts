import { Component } from '@angular/core';
import { SLApiService } from './slapi.service';

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
    this.printerStatus = false;
  }

  printers = [
    { id: 1, name: "printer1" },
    { id: 2, name: "Printer2" },
    { id: 3, name: "Printer3" }
  ];

  optionval: any = '';

  getData(printer: any) {
    alert(printer.value);
  }

  selectOption(option: string) {
    this.optionval = option;
  }

  grnNo: string = "";
  data: any[] = [];

  constructor(private slApiService: SLApiService) { }

  getDataApi() {
    const dynamicApiUrl = `https://localhost:7003/api/Inward/${this.grnNo}`;
    this.slApiService.getDynamicData(dynamicApiUrl).subscribe(
      (response) => {
        this.data = response;
      /*  console.log(this.data);
        alert('Data fetched successfully!');*/     
      },
      (error) => {
        alert('Fetching error: ' + error.status + ' - ' + error.statusText);
        console.error('Error fetching data:', error);
      }
    );
  }
}
