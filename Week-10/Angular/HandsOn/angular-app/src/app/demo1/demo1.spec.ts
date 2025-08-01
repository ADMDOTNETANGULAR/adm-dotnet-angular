import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo1 } from './demo1';

describe('Demo1', () => {
  let component: Demo1;
  let fixture: ComponentFixture<Demo1>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo1]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo1);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
