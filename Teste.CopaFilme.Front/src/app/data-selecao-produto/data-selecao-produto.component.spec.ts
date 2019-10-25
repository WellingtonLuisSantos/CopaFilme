import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DataSelecaoProdutoComponent } from './data-selecao-produto.component';

describe('DataSelecaoProdutoComponent', () => {
  let component: DataSelecaoProdutoComponent;
  let fixture: ComponentFixture<DataSelecaoProdutoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DataSelecaoProdutoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DataSelecaoProdutoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
