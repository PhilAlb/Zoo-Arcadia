import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTestimonyFormComponent } from './add-testimony-form.component';

describe('AddTestimonyFormComponent', () => {
  let component: AddTestimonyFormComponent;
  let fixture: ComponentFixture<AddTestimonyFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddTestimonyFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddTestimonyFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
