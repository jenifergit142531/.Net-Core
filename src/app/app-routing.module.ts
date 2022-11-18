import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddBookingComponent } from './add-booking/add-booking.component';
import { HomeComponent } from './home/home.component';
import { ViewBookingComponent } from './view-booking/view-booking.component';

const routes: Routes = [

{path:'',component:HomeComponent},
{path:'home',component:HomeComponent},
{path:'addbooking',component:AddBookingComponent},
{path:'viewbooking',component:ViewBookingComponent}



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
