import { Component, OnInit, Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-create-transaction',
  templateUrl: './create-transaction.component.html',
  styleUrls: ['./create-transaction.component.css']
})



export class CreateTransactionComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() trans:any;
  BuyOrder:string;
  SessionId:string;
  Amount:number;
  ReturnUrl:string;

  ngOnInit(): void {
    this.BuyOrder=this.trans.BuyOrder;
    this.SessionId=this.trans.SessionId;
    this.Amount=this.trans.Amount;
    this.ReturnUrl="http://localhost:4200/NormalReturn";
    this.createTrans();
    
  }

  
  
  createTrans(){
    var val = {Amount:this.Amount};
    this.service.createTransaction(val).subscribe(res=>{
      //alert(res.toString());
      
      var output = '';
      for (var property in res) {
        output += property + ': ' + res[property]+'; ';
      }
      alert(output);
      //https://stackoverflow.com/questions/133925/javascript-post-request-like-a-form-submit
      //post_to_url(url, params)
    });
  }

}