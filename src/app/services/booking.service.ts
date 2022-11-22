import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Booking } from 'model/booking.model';
import { bindNodeCallback, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class BookingService {


  baseApiUrl:string = environment.baseApiUrl;

  constructor(private http:HttpClient) { }

  getAllBookings(): Observable<Booking[]>
  {
    return this.http.get<Booking[]>(this.baseApiUrl+'/api/Bookings');
  }

  addBooking(addBookingRequest:Booking): Observable<Booking[]>
  {
    addBookingRequest.bid='00000000-0000-0000-0000-000000000000';
    return this.http.post<Booking[]>(this.baseApiUrl+'/api/Bookings',addBookingRequest);
  }
  
  getBookingId(bid:string):Observable<Booking>
  {
    return this.http.get<Booking>(this.baseApiUrl+'/api/bookings/'+bid);
  }

  updateBooking(bid:string,updateBookingRequest:Booking):Observable<Booking[]>
  {
     return this.http.put<Booking[]>(this.baseApiUrl+'/api/Bookings/'+bid,updateBookingRequest);
  }
  deleteBooking(bid:string):Observable<Booking>
  {
    return this.http.delete<Booking>(this.baseApiUrl+'/api/Bookings/'+bid);
  }
}
