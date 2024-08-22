import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import { filter, map, Observable, of, switchMap, take, tap } from 'rxjs';
import { RouteLinks } from '../app.routes';
import { Role } from '../interfaces/user';
import { AccountService } from '../services/account/account.service';

@Injectable({
  providedIn: 'root',
})
export class RoleGuard implements CanActivate {
  constructor(private service: AccountService, private router: Router) {}

  canActivate(route: ActivatedRouteSnapshot): Observable<boolean> {
    const expectedRole = route.data['expectedRole'];

    return this.service.role$.pipe(
      map((role: Role | null) => {       
        if (role == null || role !== expectedRole) {
          this.router.navigate([RouteLinks.Home]);
          return false;
        }
        return true;
      })
    );
  }
}
