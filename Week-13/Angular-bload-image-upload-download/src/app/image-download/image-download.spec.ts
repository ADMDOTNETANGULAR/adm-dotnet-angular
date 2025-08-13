import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImageDownload } from './image-download';

describe('ImageDownload', () => {
  let component: ImageDownload;
  let fixture: ComponentFixture<ImageDownload>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ImageDownload]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ImageDownload);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
