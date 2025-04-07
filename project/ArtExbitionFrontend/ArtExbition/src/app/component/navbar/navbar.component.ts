import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UserService } from '../../Services/user.service';
import { Router } from 'express';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterModule,FormsModule,CommonModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

 
  constructor(){}

  
}
