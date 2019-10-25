import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DataResultadoFinalComponent } from './data-resultado-final/data-resultado-final.component';
import { DataSelecaoProdutoComponent } from './data-selecao-produto/data-selecao-produto.component';


const routes: Routes = 
[
  { path: 'resultado-final', component: DataResultadoFinalComponent  },
  { path: 'selecao-produto', component: DataSelecaoProdutoComponent  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
