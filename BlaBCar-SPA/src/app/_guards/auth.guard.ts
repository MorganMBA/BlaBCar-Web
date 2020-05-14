import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { AlertifyService } from '../services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private route: Router, private alertify: AlertifyService)
  {}

  canActivate() {
    if (this.authService.logedIn()) {
      return true;
    }

    this.alertify.error('Authentification required');
    this.route.navigate(['/home']);
    return false;
  }
}
