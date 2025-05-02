import { Lead } from './../../core/models/lead';
import { Component } from '@angular/core';
import { CardAcceptedComponent } from "../../shared/components/card-accepted/card-accepted.component";
import { Observable } from 'rxjs';
import { LeadService } from '../../core/services/lead.service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-accepted',
  imports: [CardAcceptedComponent, AsyncPipe],
  templateUrl: './accepted.component.html',
  styleUrl: './accepted.component.scss'
})
export class AcceptedComponent {
  
  lead$?: Observable<Lead[]>;

  constructor(private leadService: LeadService){ }
  
  ngOnInit(): void {
    this.getLead();
  }

  getLead() {
    this.lead$ = this.leadService.getLeads(1);
  }
}
