import { Component, OnInit } from '@angular/core';
import { Booking } from 'model/booking.model';
import { BookingService } from '../services/booking.service';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-booking',
  templateUrl: './add-booking.component.html',
  styleUrls: ['./add-booking.component.css']
})
export class AddBookingComponent implements OnInit {

  addBookingRequest:Booking={
    bid:'',
    bname:'',
    mname:'',
    ticketprice:0
 };


  constructor(private bookingservice:BookingService,private router:Router) { }

  ngOnInit(): void {
  }

  addBooking()
  {
    this.bookingservice.addBooking(this.addBookingRequest)
    .subscribe({
     next:(bookings) =>
        {
          this.router.navigate(['viewbooking']);
          console.log(bookings);
        },
        error:(response)=>
        {
          console.log(response);
        }
    }) 
  }

}
