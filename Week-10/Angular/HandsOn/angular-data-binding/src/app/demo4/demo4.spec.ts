import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo4 } from './demo4';

describe('Demo4', () => {
  let component: Demo4;
  let fixture: ComponentFixture<Demo4>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo4]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo4);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
