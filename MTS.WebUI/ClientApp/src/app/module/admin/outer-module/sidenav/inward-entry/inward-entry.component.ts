import { Component } from '@angular/core';
import { InwardServicesService } from './inward-services.service';


@Component({
  selector: 'app-inward-entry',
  templateUrl: './inward-entry.component.html',
  styleUrls: ['./inward-entry.component.css']
})
export class InwardEntryComponent {
  grnNo: string = "";
  data: any[] = [];

  constructor(private inwardServicesService: InwardServicesService) { }

  getDataApi() {
    const dynamicApiUrl = `https://localhost:7003/api/Inward/${this.grnNo}`;
    this.inwardServicesService.getDynamicData(dynamicApiUrl).subscribe(
      (response) => {
        this.data = response;
      },
      (error) => {
        alert('Fetching error: ' + error.status + ' - ' + error.statusText);
        console.error('Error fetching data:', error);
      }
    );
  }
}
