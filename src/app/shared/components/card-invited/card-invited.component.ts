import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Lead } from '../../../core/models/lead';
import { CurrencyPipe, DatePipe } from '@angular/common';



@Component({
  selector: 'app-card-invited',
  imports: [CurrencyPipe, DatePipe],
  templateUrl: './card-invited.component.html',
  styleUrl: './card-invited.component.scss'
})
export class CardInvitedComponent {

  @Input() lead?: Lead | any;
  @Output() acceptedResult = new EventEmitter<any>();
  @Output() declineResult = new EventEmitter<any>();


  onAccept() {
    this.acceptedResult.emit(this.lead);
  }

  onDecline() {
    this.declineResult.emit(this.lead);
  }

}
