import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SendEmailToAdminDto } from '../models/email/send-email-to-admin-dto';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class EmailService {
    apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  sendToAdmin(dto: SendEmailToAdminDto){
    return this.http.post(this.apiUrl + "email/send", dto);
  }
}
