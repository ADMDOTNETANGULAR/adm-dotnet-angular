import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Child1 } from './child-1';

describe('Child1', () => {
  let component: Child1;
  let fixture: ComponentFixture<Child1>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Child1]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Child1);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
