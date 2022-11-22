import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Booking } from 'model/booking.model';
import { BookingService } from '../services/booking.service';

@Component({
  selector: 'app-edit-booking',
  templateUrl: './edit-booking.component.html',
  styleUrls: ['./edit-booking.component.css']
})
export class EditBookingComponent implements OnInit {

  bookingDetails:Booking={
    bid:'',
    bname:'',
    mname:'',
    ticketprice:0
 };

  constructor(private route:ActivatedRoute,private bookingService:BookingService,private router:Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next:(params)=>
      {
        const bid=params.get('bid');
        if(bid){
          this.bookingService.getBookingId(bid)
          .subscribe({
            next:(response)=>{
              this.bookingDetails=response;
            }
          })
        }
      }
    })
  }

  updateBooking()
  {
    this.bookingService.updateBooking(this.bookingDetails.bid,this.bookingDetails)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['viewbooking']);
      },
      error:(response)=>
      {
        console.log(response);
      }
    });
  }

  deleteBooking(bid:string)
  {
    this.bookingService.deleteBooking(bid)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['viewbooking']);
      },
      error:(response)=>
      {
        console.log(response);
      }
    });
  }

}
