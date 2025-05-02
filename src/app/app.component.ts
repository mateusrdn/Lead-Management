import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TabsComponent } from "./shared/components/tabs/tabs.component";
import { LeadService } from './core/services/lead.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TabsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit{

  constructor(private leadService: LeadService) { }

  tabs = [
    { label: 'Invited', router: '/invited' },
    { label: 'Accepted', router: '/accepted' }
  ];

  ngOnInit(): void {
    this.leadService.getLeads(0).subscribe((leads) => {
      console.log(leads);
    });

    this.leadService.getLeads(1).subscribe((leads) => {
      console.log(leads);
    });
  }
}
