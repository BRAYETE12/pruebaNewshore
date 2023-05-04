import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JourneyDto } from '../Models/JourneyDto';
import { Observable } from 'rxjs';
import { ResponseDTO } from '../Models/ResponseDTO';

@Injectable({
  providedIn: 'root'
})
export class JourneyService {

  constructor(private http: HttpClient) { 
  }

  get(journeyDto: JourneyDto) : Observable<ResponseDTO>
  {
    return this.http.get<ResponseDTO>(`https://localhost:7093/api/Journey?Origin=${journeyDto.Origin}&Destination=${journeyDto.Destination}`, {});
  }
}
