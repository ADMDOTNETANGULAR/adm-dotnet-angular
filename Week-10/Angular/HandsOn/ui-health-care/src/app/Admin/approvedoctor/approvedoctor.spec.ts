import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Approvedoctor } from './approvedoctor';

describe('Approvedoctor', () => {
  let component: Approvedoctor;
  let fixture: ComponentFixture<Approvedoctor>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Approvedoctor]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Approvedoctor);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
