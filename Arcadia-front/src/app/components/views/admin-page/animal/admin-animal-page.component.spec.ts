import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminAnimalPageComponent } from './admin-animal-page.component';

describe('AdminAnimalPageComponent', () => {
  let component: AdminAnimalPageComponent;
  let fixture: ComponentFixture<AdminAnimalPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminAnimalPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminAnimalPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
