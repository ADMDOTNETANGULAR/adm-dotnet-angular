import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Patienddashboard } from './patienddashboard';

describe('Patienddashboard', () => {
  let component: Patienddashboard;
  let fixture: ComponentFixture<Patienddashboard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Patienddashboard]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Patienddashboard);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
