import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo2 } from './demo2';

describe('Demo2', () => {
  let component: Demo2;
  let fixture: ComponentFixture<Demo2>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo2]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo2);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
