import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthResponseModel, Login } from '../models/login';
import { BehaviorSubject, Observable } from 'rxjs';
import { Register, RegistrationResponse } from '../models/register';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private loggedIn=new BehaviorSubject<boolean>(this.isLoggedIn());
  isLoggedIn$=this.loggedIn.asObservable();
  private apiUrl="https://localhost:7084/api/Auth";
//https://localhost:7134/api/Auth/login
//https://localhost:7134/api/Auth/register
  constructor(private http:HttpClient) { }

  login(loginData:Login):Observable<AuthResponseModel>{
    return this.http.post<AuthResponseModel>(`${this.apiUrl}/login`,loginData)
  }

  register(user:Register):Observable<RegistrationResponse>{
    return this.http.post<RegistrationResponse>(`${this.apiUrl}/register`,user)
  }

  // isLoggedIn():boolean{
  // let tokenValue= localStorage.getItem('token');
  // if(tokenValue){
  //   return true;
  
  // }
  // else{
  //   return false;
  // }
  // }
  isLoggedIn():boolean{
    return !!localStorage.getItem('token');
  }
  //To Notify subscribes
  updateLoginStatus(isLoggedIn:boolean){
    this.loggedIn.next(isLoggedIn);
  }
}