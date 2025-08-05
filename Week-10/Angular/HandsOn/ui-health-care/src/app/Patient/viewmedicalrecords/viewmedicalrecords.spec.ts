import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Viewmedicalrecords } from './viewmedicalrecords';

describe('Viewmedicalrecords', () => {
  let component: Viewmedicalrecords;
  let fixture: ComponentFixture<Viewmedicalrecords>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Viewmedicalrecords]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Viewmedicalrecords);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
