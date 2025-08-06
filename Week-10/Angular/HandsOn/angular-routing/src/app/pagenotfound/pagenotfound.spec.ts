import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Pagenotfound } from './pagenotfound';

describe('Pagenotfound', () => {
  let component: Pagenotfound;
  let fixture: ComponentFixture<Pagenotfound>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Pagenotfound]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Pagenotfound);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
