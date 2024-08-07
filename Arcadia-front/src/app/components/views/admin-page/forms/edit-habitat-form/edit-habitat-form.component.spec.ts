import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditHabitatFormComponent } from './edit-habitat-form.component';

describe('EditHabitatFormComponent', () => {
  let component: EditHabitatFormComponent;
  let fixture: ComponentFixture<EditHabitatFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditHabitatFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditHabitatFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
