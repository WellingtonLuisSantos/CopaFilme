import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DataResultadoFinalComponent } from './data-resultado-final.component';

describe('DataResultadoFinalComponent', () => {
  let component: DataResultadoFinalComponent;
  let fixture: ComponentFixture<DataResultadoFinalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DataResultadoFinalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DataResultadoFinalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
