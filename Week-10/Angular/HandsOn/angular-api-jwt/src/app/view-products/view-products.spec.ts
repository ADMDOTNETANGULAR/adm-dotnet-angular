import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewProducts } from './view-products';

describe('ViewProducts', () => {
  let component: ViewProducts;
  let fixture: ComponentFixture<ViewProducts>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewProducts]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ViewProducts);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
