import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarouselTestimoniesComponent } from './testimonies.component';

describe('CarouselTestimoniesComponent', () => {
  let component: CarouselTestimoniesComponent;
  let fixture: ComponentFixture<CarouselTestimoniesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarouselTestimoniesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarouselTestimoniesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
