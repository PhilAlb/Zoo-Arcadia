import { Routes } from '@angular/router';
import { HomePageComponent } from './components/views/home-page/home-page.component';
import { ServicesPageComponent } from './components/views/services-page/services-page.component';
import { HabitatsPageComponent } from './components/views/habitats-page/habitats-page.component';
import { AdminPageComponent } from './components/views/admin-page/admin-page.component';
import { AdminAnimalPageComponent } from './components/views/admin-page/animal/admin-animal-page.component';
import { AdminHabitatPageComponent } from './components/views/admin-page/habitat/admin-habitat-page.component';
import { AdminServicePageComponent } from './components/views/admin-page/service/admin-service-page.component';
import { AdminTestimonyPageComponent } from './components/views/admin-page/testimony/admin-testimony-page.component';
import { AdminUserPageComponent } from './components/views/admin-page/user/admin-user-page.component';

export enum RouteLinks {
  Home = 'home',
  Services = 'services',
  Habitats = 'habitats',
  Contact = 'contact',
  Admin = 'admin',
  Users = 'users',
  Testimonies = 'testimonies',
  Animals = 'animals'
}

export const routes: Routes = [
  { path: RouteLinks.Home, component: HomePageComponent },
  { path: RouteLinks.Services, component: ServicesPageComponent },
  { path: RouteLinks.Habitats, component: HabitatsPageComponent },
  { path: RouteLinks.Contact, component: HomePageComponent },
  {
    path: RouteLinks.Admin, component: AdminPageComponent,
    children: [
      {
        path: RouteLinks.Animals,
        component: AdminAnimalPageComponent,
      },
      {
        path: RouteLinks.Habitats,
        component: AdminHabitatPageComponent,
      },
      {
        path: RouteLinks.Services,
        component: AdminServicePageComponent,
      },
      {
        path: RouteLinks.Testimonies,
        component: AdminTestimonyPageComponent,
      },
      {
        path: RouteLinks.Users,
        component: AdminUserPageComponent,
      },
    ]
  },
  // {} // employees
  // {} // veterinaries
  { path: '', redirectTo: RouteLinks.Home, pathMatch: 'full' },
  { path: '**', redirectTo: RouteLinks.Home, pathMatch: 'full' },
];
