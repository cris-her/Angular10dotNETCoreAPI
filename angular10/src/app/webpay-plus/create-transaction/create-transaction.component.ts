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
  }
  
  createTrans(){
    var val = {BuyOrder:this.BuyOrder,
                SessionId:this.SessionId,
                Amount:this.Amount,
                ReturnUrl:this.ReturnUrl};
    this.service.createTransaction(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updateDepartment(){
    /*
    var val = {DepartmentId:this.DepartmentId,
      DepartmentName:this.DepartmentName};
    this.service.updateDepartment(val).subscribe(res=>{
    alert(res.toString());
    });*/
  }

}