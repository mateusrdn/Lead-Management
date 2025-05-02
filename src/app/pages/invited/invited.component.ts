import { Component, OnInit } from '@angular/core';
import { CardInvitedComponent } from "../../shared/components/card-invited/card-invited.component";
import { LeadService } from '../../core/services/lead.service';
import { AsyncPipe } from '@angular/common';
import { Observable } from 'rxjs';
import { Lead } from '../../core/models/lead';

@Component({
  selector: 'app-invited',
  imports: [CardInvitedComponent, AsyncPipe],
  templateUrl: './invited.component.html',
  styleUrl: './invited.component.scss'
})
export class InvitedComponent implements OnInit {

  lead$?: Observable<Lead[]>;

  constructor(private leadService: LeadService){ }
  
  ngOnInit(): void {
    this.getLead();
  }

  getLead() {
    this.lead$ = this.leadService.getLeads(0);
  }

  acceptedLead(event: any){
    this.leadService.putAccept(event.id).subscribe({
      next: (response) => {
        this.getLead();
      },
      error: (error) => {
        console.error('Error accepting lead:', error);
      }
    })
  }

  declineLead(event: any){
    this.leadService.putDecline(event.id).subscribe({
      next: (response) => {
        this.getLead();
      },
      error: (error) => {
        console.error('Error accepting lead:', error);
      }
    })
  }

}
