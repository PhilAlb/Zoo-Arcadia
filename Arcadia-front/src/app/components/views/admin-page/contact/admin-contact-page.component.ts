import { Component, OnInit } from '@angular/core';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { Contact } from '../../../../interfaces/admin/contact';
import { ContactService } from '../../../../services/contact/contact.service';

@Component({
  selector: 'app-admin-contact-page',
  standalone: true,
  imports: [ConfirmationModalComponent],
  templateUrl: './admin-contact-page.component.html',
  styleUrl: './admin-contact-page.component.scss',
})
export class AdminContactPageComponent implements OnInit {
  list: Contact[] = [];

  constructor(private service: ContactService) {}

  ngOnInit(): void {
    this.getList();
  }

  getList(): void {
    this.service
      .getContacts()
      .subscribe((data: Contact[]) => (this.list = data));
  }

  delete(id: number): void {
    this.service
      .deleteContact(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
