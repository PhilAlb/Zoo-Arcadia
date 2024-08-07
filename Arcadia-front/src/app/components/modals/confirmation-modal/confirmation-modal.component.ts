import { Component, Output, EventEmitter, Input } from '@angular/core';

@Component({
  selector: 'app-confirmation-modal',
  standalone: true,
  imports: [],
  templateUrl: './confirmation-modal.component.html',
  styleUrl: './confirmation-modal.component.scss',
})
export class ConfirmationModalComponent {
  @Input() id?: number;
  @Output() confirmationSent = new EventEmitter<boolean>();

  confirm(): void {
    this.confirmationSent.emit(true);
  }
}
