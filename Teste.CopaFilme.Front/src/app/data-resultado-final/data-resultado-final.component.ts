import { Component, OnInit } from '@angular/core';
import { Partida } from '../model/Partida.model';
import { CopafilmeserviceService } from '../Services/copafilmeservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-data-resultado-final',
  templateUrl: './data-resultado-final.component.html',
  styleUrls: ['./data-resultado-final.component.css']
})
export class DataResultadoFinalComponent implements OnInit {

  campeao: string;
  vicecampeao: string;
  partidaFinal: Partida

  constructor(private CopaFilmeService : CopafilmeserviceService, private route: Router) 
  { 

  }

  ngOnInit(): void 
  {
    this.partidaFinal = this.CopaFilmeService.partidaFinal;
    this.CopaFilmeService.partidaFinal = undefined;

    if(this.partidaFinal.vencedor == this.partidaFinal.filme1.id)
    {
      this.campeao = this.partidaFinal.filme1.titulo;
      this.vicecampeao = this.partidaFinal.filme2.titulo;
    }
    else
    {
      this.campeao = this.partidaFinal.filme2.titulo;
      this.vicecampeao = this.partidaFinal.filme1.titulo;
    }
  }

  goToNovo(): void 
  {
    this.route.navigate(['/selecao-produto']);
  }

}