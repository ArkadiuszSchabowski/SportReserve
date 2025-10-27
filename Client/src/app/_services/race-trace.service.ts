import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddRaceTraceDto } from '../models/race/add-race-trace-dto';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root',
})
export class RaceTraceService {
  apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  add(dto: AddRaceTraceDto) {
    const token = localStorage.getItem('token');
    const headers = new HttpHeaders().set('Authorization', `Bearer ${token}`);

    return this.http.post(this.apiUrl + 'racetrace', dto, {headers});
  }
  remove(id: number) {
    const token = localStorage.getItem('token');
    const headers = new HttpHeaders().set('Authorization', `Bearer ${token}`);

    return this.http.delete(this.apiUrl + `racetrace/${id}`, {headers});
  }
}
