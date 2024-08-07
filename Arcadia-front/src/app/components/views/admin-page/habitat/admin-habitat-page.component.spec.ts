import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminHabitatPageComponent } from './admin-habitat-page.component';

describe('AdminHabitatPageComponent', () => {
  let component: AdminHabitatPageComponent;
  let fixture: ComponentFixture<AdminHabitatPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminHabitatPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminHabitatPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
