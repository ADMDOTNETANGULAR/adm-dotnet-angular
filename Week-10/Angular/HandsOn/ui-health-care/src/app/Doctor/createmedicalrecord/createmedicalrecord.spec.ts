import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Createmedicalrecord } from './createmedicalrecord';

describe('Createmedicalrecord', () => {
  let component: Createmedicalrecord;
  let fixture: ComponentFixture<Createmedicalrecord>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Createmedicalrecord]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Createmedicalrecord);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
