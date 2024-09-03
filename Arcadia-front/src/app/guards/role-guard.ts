import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import { map, Observable } from 'rxjs';
import { RouteLinks } from '../app.routes';
import { Role } from '../interfaces/admin/user';
import { AccountService } from '../services/account/account.service';

@Injectable({
  providedIn: 'root',
})
export class RoleGuard implements CanActivate {
  constructor(private service: AccountService, private router: Router) {}

  canActivate(route: ActivatedRouteSnapshot): Observable<boolean> {
    const expectedRoles: Role[] = route.data['expectedRoles'];

    return this.service.role$.pipe(
      map((role: Role | null) => {       
        if (role == null || !expectedRoles.includes(role)) {
          this.router.navigate([RouteLinks.Home]);
          return false;
        }
        return true;
      })
    );
  }
}
