import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Editprofile } from './editprofile';

describe('Editprofile', () => {
  let component: Editprofile;
  let fixture: ComponentFixture<Editprofile>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Editprofile]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Editprofile);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
