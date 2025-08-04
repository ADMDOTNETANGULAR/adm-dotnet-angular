import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo5 } from './demo5';

describe('Demo5', () => {
  let component: Demo5;
  let fixture: ComponentFixture<Demo5>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo5]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo5);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
