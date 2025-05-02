
import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardInvitedComponent } from './card-invited.component';

describe('CardComponent', () => {
  let component: CardInvitedComponent;
  let fixture: ComponentFixture<CardInvitedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CardInvitedComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CardInvitedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
