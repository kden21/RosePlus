import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgreePageComponent } from './agree-page.component';

describe('AgreePageComponent', () => {
  let component: AgreePageComponent;
  let fixture: ComponentFixture<AgreePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgreePageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgreePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
