import { Component } from '@angular/core';
import { JourneyService } from './Services/journey.service';
import { JourneyDto } from './Models/JourneyDto';
import { Journey } from './Models/Journey';
import { ResponseDTO } from './Models/ResponseDTO';
import { Money } from './Models/Money';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  loading: boolean = false;
  journeyDto: JourneyDto = { Origin:"", Destination:""};
  journey!: Journey;
  message! : string;
  selctMoney : Money;
  money : Money[] = [ { Name : 'USD', TAX: 1 }, { Name: "COP", TAX : 4635.33 }, { Name: "EUR", TAX : 0.91 }, { Name: "GBP", TAX : 0.79 }  ];

  constructor(private servi: JourneyService)
  {
    this.selctMoney = this.money[0];
  }

  search()
  {
    if( !(this.journeyDto.Origin && this.journeyDto.Destination) ) return;
    
    if(this.journeyDto.Origin == this.journeyDto.Destination)
    {
      this.message = "Origin and destination must be different";
      return;
    }
    
    this.loading = true;
    if(this.journey) this.journey.Flights = [];
    this.selctMoney = this.money[0];
    this.message = "";
 
    this.servi.get(this.journeyDto)
    .subscribe((response:ResponseDTO)=>{

      if(response.StatusCode == 200)
      {
        this.journey = response.Object;
      }
      else
      {
       this.message = response.Message;
      }

      this.loading = false;
    },
    (err:any)=>{ this.loading = false; })

  }

  keyFuncOrigin(event:any){
    this.journeyDto.Origin = event.target.value.toUpperCase();
  }
  
  keyFuncDestination(event:any){
    this.journeyDto.Destination = event.target.value.toUpperCase();
  }

}
