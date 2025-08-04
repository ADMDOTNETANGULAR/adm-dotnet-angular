import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo3 } from './demo3';

describe('Demo3', () => {
  let component: Demo3;
  let fixture: ComponentFixture<Demo3>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo3]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo3);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
