import { Component, input, Input } from '@angular/core';
import { Lead } from '../../../core/models/lead';
import { CurrencyPipe, DatePipe } from '@angular/common';

@Component({
  selector: 'app-card-accepted',
  imports: [CurrencyPipe, DatePipe],
  templateUrl: './card-accepted.component.html',
  styleUrl: './card-accepted.component.scss'
})
export class CardAcceptedComponent {

  @Input() lead!: Lead | any;

}
