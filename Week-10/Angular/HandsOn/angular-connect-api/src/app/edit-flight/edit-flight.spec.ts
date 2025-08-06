import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditFlight } from './edit-flight';

describe('EditFlight', () => {
  let component: EditFlight;
  let fixture: ComponentFixture<EditFlight>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditFlight]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditFlight);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
