import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventtosComponent } from './eventtos.component';

describe('EventtosComponent', () => {
  let component: EventtosComponent;
  let fixture: ComponentFixture<EventtosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EventtosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EventtosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
