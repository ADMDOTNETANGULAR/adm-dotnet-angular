import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo6 } from './demo6';

describe('Demo6', () => {
  let component: Demo6;
  let fixture: ComponentFixture<Demo6>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo6]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo6);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
