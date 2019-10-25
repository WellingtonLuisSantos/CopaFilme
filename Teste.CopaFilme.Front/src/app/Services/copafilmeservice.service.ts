import { HttpClient } from '@angular/common/http';

import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Filme } from '../model/Filme.model';
import { Partida } from '../model/Partida.model';

@Injectable({
  providedIn: 'root'
})
export class CopafilmeserviceService 
{

  partidaFinal: Partida;

  constructor(private http: HttpClient) 
  { 

  }

  public GetFilmes(): Observable<any>
  {
    return this.http.get('https://localhost:44354/api/filme');
  }

  public PostProcessarCopa(filme : Array<Filme>) : Observable<any>
  {
    return this.http.post('https://localhost:44354/api/partida/', filme); 
  }

}