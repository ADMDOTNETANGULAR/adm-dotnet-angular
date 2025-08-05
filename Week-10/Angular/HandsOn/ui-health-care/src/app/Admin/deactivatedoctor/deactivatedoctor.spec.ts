import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Deactivatedoctor } from './deactivatedoctor';

describe('Deactivatedoctor', () => {
  let component: Deactivatedoctor;
  let fixture: ComponentFixture<Deactivatedoctor>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Deactivatedoctor]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Deactivatedoctor);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
