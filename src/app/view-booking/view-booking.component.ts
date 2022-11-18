import { Component, OnInit } from '@angular/core';
import { Booking } from 'model/booking.model';
import { BookingService } from '../services/booking.service';

@Component({
  selector: 'app-view-booking',
  templateUrl: './view-booking.component.html',
  styleUrls: ['./view-booking.component.css']
})
export class ViewBookingComponent implements OnInit {

  bookings:Booking[]=[];

  constructor(private bookingservices:BookingService) { }

  ngOnInit(): void {
    this.bookingservices.getAllBookings()
    .subscribe({
      next:(bookings)=>
      {
       this.bookings=bookings;
      },
      error:(response)=>
      {
        console.log(response);
      }

    })
  }
  

}
