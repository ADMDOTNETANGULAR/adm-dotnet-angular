import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Doctordashboard } from './doctordashboard';

describe('Doctordashboard', () => {
  let component: Doctordashboard;
  let fixture: ComponentFixture<Doctordashboard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Doctordashboard]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Doctordashboard);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
