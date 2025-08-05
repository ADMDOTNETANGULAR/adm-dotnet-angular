import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewFlights } from './view-flights';

describe('ViewFlights', () => {
  let component: ViewFlights;
  let fixture: ComponentFixture<ViewFlights>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewFlights]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ViewFlights);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
