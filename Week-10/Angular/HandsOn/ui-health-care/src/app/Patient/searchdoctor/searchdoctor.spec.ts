import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Searchdoctor } from './searchdoctor';

describe('Searchdoctor', () => {
  let component: Searchdoctor;
  let fixture: ComponentFixture<Searchdoctor>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Searchdoctor]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Searchdoctor);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
