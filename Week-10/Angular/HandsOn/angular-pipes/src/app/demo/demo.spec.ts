import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo } from './demo';

describe('Demo', () => {
  let component: Demo;
  let fixture: ComponentFixture<Demo>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
