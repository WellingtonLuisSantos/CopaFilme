import { Component, OnInit } from '@angular/core';
import { CopafilmeserviceService } from '../Services/copafilmeservice.service';
import { Filme } from '../model/Filme.model';
import { Partida } from '../model/Partida.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-data-selecao-produto',
  templateUrl: './data-selecao-produto.component.html',
  styleUrls: ['./data-selecao-produto.component.css']
})
export class DataSelecaoProdutoComponent implements OnInit {

  filmesOpcoes: Array<Filme>;
  filmesSelecionados: Filme[] = [];
  partidaFinal: Partida;
  qtdSelecionado: number = 0;

  constructor(private CopaFilmeService : CopafilmeserviceService, private route: Router) 
  { 
    this.consultarFilmes();
  }
  
  ngOnInit() { }

  atualizarQtdSelecionado(checked: any, id: string)
  {
    if(checked.target.checked)
    {
      this.filmesSelecionados.push(this.filmesOpcoes.find(x => x.id == id));
    }
    else
    {
      delete this.filmesSelecionados[this.filmesSelecionados.findIndex(x => x.id == id)];
    }

    this.qtdSelecionado += (checked.target.checked ? 1 : -1);
  }

  consultarFilmes()
  {
    this.CopaFilmeService.GetFilmes().subscribe(
      
      (data: Array<Filme>) => 
      {
        this.filmesOpcoes = data;
      }, 
      error => 
      {
        console.log(error);
      });
  }

  processarCopa()
  {
    if(this.qtdSelecionado != 8)
    {
      alert("Necessario selecionar 8 filmes para iniciar o Campeonato.");
    }
    else
    {
        this.CopaFilmeService.PostProcessarCopa(this.filmesSelecionados).subscribe(
      
        (data: Partida) => 
        {
          this.partidaFinal = data;   
          this.goToResultado();
        }, 
        error => 
        {
          console.log(error);
        });
    }
  }

  goToResultado(): void 
  {
    this.CopaFilmeService.partidaFinal = this.partidaFinal;
    this.route.navigate(['/resultado-final']);
  }

}
