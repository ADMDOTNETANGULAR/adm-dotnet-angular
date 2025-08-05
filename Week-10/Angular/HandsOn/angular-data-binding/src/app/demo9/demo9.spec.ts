import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo9 } from './demo9';

describe('Demo9', () => {
  let component: Demo9;
  let fixture: ComponentFixture<Demo9>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo9]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo9);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
