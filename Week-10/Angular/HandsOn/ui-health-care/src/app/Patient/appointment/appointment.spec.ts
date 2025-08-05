import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Appointment } from './appointment';

describe('Appointment', () => {
  let component: Appointment;
  let fixture: ComponentFixture<Appointment>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Appointment]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Appointment);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
