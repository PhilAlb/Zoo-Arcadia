import { Component, OnInit } from '@angular/core';
import { ServiceDto } from '../../../../interfaces/admin/service';
import { ServiceService } from '../../../../services/service/service.service';
import { AddServiceFormComponent } from '../forms/add-service-form/add-service-form.component';
import { EditServiceFormComponent } from '../forms/edit-service-form/edit-service-form.component';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';

@Component({
  selector: 'app-admin-service-page',
  standalone: true,
  imports: [
    AddServiceFormComponent,
    EditServiceFormComponent,
    ConfirmationModalComponent,
  ],
  templateUrl: './admin-service-page.component.html',
  styleUrl: './admin-service-page.component.scss',
})
export class AdminServicePageComponent implements OnInit {
  list: ServiceDto[] = [];

  constructor(private _service: ServiceService) {}

  ngOnInit(): void {
    this.getList();
  }

  getList(): void {
    this._service
      .getServices()
      .subscribe((data: ServiceDto[]) => (this.list = data));
  }

  add(service: ServiceDto): void {
    this._service.addService(service).subscribe(() => this.getList());
  }

  edit(service: ServiceDto): void {
    this._service.updateService(service).subscribe(() => this.getList());
  }

  delete(id: number): void {
    this._service
      .deleteService(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
