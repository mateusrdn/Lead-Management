import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardAcceptedComponent } from './card-accepted.component';

describe('CardAcceptedComponent', () => {
  let component: CardAcceptedComponent;
  let fixture: ComponentFixture<CardAcceptedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CardAcceptedComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CardAcceptedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
