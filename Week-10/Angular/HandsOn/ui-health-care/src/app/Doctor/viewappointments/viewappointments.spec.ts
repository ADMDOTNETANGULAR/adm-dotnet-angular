import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Viewappointments } from './viewappointments';

describe('Viewappointments', () => {
  let component: Viewappointments;
  let fixture: ComponentFixture<Viewappointments>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Viewappointments]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Viewappointments);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
