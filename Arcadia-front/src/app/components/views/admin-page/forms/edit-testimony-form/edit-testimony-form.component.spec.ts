import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTestimonyFormComponent } from './edit-testimony-form.component';

describe('EditTestimonyFormComponent', () => {
  let component: EditTestimonyFormComponent;
  let fixture: ComponentFixture<EditTestimonyFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditTestimonyFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditTestimonyFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
