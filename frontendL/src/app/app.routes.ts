import { Routes } from '@angular/router';
import { InvitedComponent } from './pages/invited/invited.component';
import { AcceptedComponent } from './pages/accepted/accepted.component';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'invited',
    pathMatch: 'full'
  },
  {
    path: 'invited',
    component: InvitedComponent
  },
  {
    path: 'accepted',
    component: AcceptedComponent
  }
];
