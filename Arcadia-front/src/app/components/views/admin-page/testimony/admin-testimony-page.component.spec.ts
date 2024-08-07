import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminTestimonyPageComponent } from './admin-testimony-page.component';

describe('AdminTestimonyPageComponent', () => {
  let component: AdminTestimonyPageComponent;
  let fixture: ComponentFixture<AdminTestimonyPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminTestimonyPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminTestimonyPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
