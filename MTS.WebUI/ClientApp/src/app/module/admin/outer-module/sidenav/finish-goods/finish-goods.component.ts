import { Component, OnInit } from '@angular/core';
import { tap } from 'rxjs';
import { MyDataService } from './my-data.service';

@Component({
  selector: 'app-finish-goods',
  templateUrl: './finish-goods.component.html',
  styleUrls: ['./finish-goods.component.css']
})
export class FinishGoodsComponent implements OnInit {

  myData: any;
 
  constructor(private myDataService: MyDataService) { }
  ngOnInit(): void {

    this.myDataService.getData1().subscribe((data) => {
      console.warn("data",data);
    })
    
    console.log('hijsidjsi')
  }
}
