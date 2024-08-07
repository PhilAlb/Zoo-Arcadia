import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddHabitatFormComponent } from './add-habitat-form.component';

describe('AddHabitatFormComponent', () => {
  let component: AddHabitatFormComponent;
  let fixture: ComponentFixture<AddHabitatFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddHabitatFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddHabitatFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
