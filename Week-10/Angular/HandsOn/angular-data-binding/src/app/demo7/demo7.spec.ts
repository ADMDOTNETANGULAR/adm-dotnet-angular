import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo7 } from './demo7';

describe('Demo7', () => {
  let component: Demo7;
  let fixture: ComponentFixture<Demo7>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo7]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo7);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
