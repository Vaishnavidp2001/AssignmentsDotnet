import { Routes } from '@angular/router';
import { RegisterComponent } from './component/register/register.component';
import { LoginComponent } from './component/login/login.component';
import { HomeComponent } from './component/home/home.component';
import { ArtworkComponent } from './component/artwork/artwork.component';

export const routes: Routes = [
    {path:'register', component:RegisterComponent},
    {path:'login', component:LoginComponent},
    {path:'home',component:HomeComponent},
    {path:'artworks', component:ArtworkComponent},
  {path:'**',component:HomeComponent}  
];
