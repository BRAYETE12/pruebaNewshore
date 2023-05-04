import { Component } from '@angular/core';
import { JourneyService } from './Services/journey.service';
import { JourneyDto } from './Models/JourneyDto';
import { Journey } from './Models/Journey';
import { ResponseDTO } from './Models/ResponseDTO';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  loading: boolean = false;
  journeyDto: JourneyDto = new JourneyDto();
  journey: Journey = new Journey();
  message! : string;

  constructor(private servi: JourneyService){}

  search()
  {
    if( !(this.journeyDto.Origin && this.journeyDto.Destination) ) return;
    
    if(this.journeyDto.Origin == this.journeyDto.Destination)
    {
      this.message = "Origin and destination must be different";
      return;
    }
    
    this.loading = true;
    this.journey.Flights = [];
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
