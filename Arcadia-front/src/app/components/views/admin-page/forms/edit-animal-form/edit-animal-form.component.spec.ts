import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditAnimalFormComponent } from './edit-animal-form.component';

describe('EditAnimalFormComponent', () => {
  let component: EditAnimalFormComponent;
  let fixture: ComponentFixture<EditAnimalFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditAnimalFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditAnimalFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
