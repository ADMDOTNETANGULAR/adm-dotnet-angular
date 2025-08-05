import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo8 } from './demo8';

describe('Demo8', () => {
  let component: Demo8;
  let fixture: ComponentFixture<Demo8>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Demo8]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Demo8);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
