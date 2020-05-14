import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { TrajetComponent } from './trajet/trajet.component';
import { ValueComponent } from './value/value.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptor, ErrorInterceptorProvider } from './services/ErrorInterceptor';
import { ReservationComponent } from './reservation/reservation.component';
import { ProposerComponent } from './trajet/proposer/proposer.component';
import { RechercherComponent } from './trajet/rechercher/rechercher.component';
import { appRoutes } from './routes';

@NgModule({
  declarations: [
    AppComponent,
    TrajetComponent,
    ValueComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    ReservationComponent,
    ProposerComponent,
    RechercherComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    BsDropdownModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    AuthService,
    ErrorInterceptorProvider
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
