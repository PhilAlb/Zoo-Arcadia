import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarouselAnimalsComponent } from './carousel-animals.component';

describe('CarouselAnimalsComponent', () => {
  let component: CarouselAnimalsComponent;
  let fixture: ComponentFixture<CarouselAnimalsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarouselAnimalsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarouselAnimalsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
