import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestimonyModalComponent } from './testimony-modal.component';

describe('TestimonyModalComponent', () => {
  let component: TestimonyModalComponent;
  let fixture: ComponentFixture<TestimonyModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TestimonyModalComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TestimonyModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
