import { CommonModule } from '@angular/common';
import { Component, inject, Input, input } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

export interface Tab {
  label: string;
  router: string;
}

@Component({
  selector: 'app-tabs',
  imports: [CommonModule, RouterModule],
  templateUrl: './tabs.component.html',
  styleUrl: './tabs.component.scss'
})
export class TabsComponent {

  @Input() tabs: any[] = [];

}
