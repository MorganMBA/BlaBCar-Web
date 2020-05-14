import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ReservationComponent } from './reservation/reservation.component';
import { ProposerComponent } from './trajet/proposer/proposer.component';
import { RechercherComponent } from './trajet/rechercher/rechercher.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  {path: '', component: HomeComponent},
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'reservations', component: ReservationComponent},
      {path: 'proposer-trajet', component: ProposerComponent},
      {path: 'rechercher-trajet', component: RechercherComponent}
    ]
  },
  {path: '**', redirectTo: '', pathMatch: 'full'}
];
