import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventtos',
  templateUrl: './eventtos.component.html',
  styleUrls: ['./eventtos.component.scss']
})
export class EventtosComponent implements OnInit {


  // public eventos : any =   [
  //   {
  //   Tema : 'Angular',
  //   Local: 'Belo Horizonte'
  //   },
  //   {
  //     Tema : 'Dot Net 5',
  //     Local: 'Porto Alegre'
  //   },
  //   {
  //     Tema : 'Delphi',
  //     Local: 'São Paulo'
  //   }
  // ]

  public eventos : any;

  constructor(private http : HttpClient) { }

  ngOnInit(): void {
     this.getEventos();
  }

  public getEventos() : void {
    this.http.get('https://localhost:5001/api/eventto').subscribe(
      response => this.eventos = response,
      error => console.log(error)

    );

    // this.eventos = [
    //     {
    //     Tema : 'Angular',
    //     Local: 'Belo Horizonte'
    //     },
    //     {
    //       Tema : 'Dot Net 5',
    //       Local: 'Porto Alegre'
    //     },
    //     {
    //       Tema : 'Delphi',
    //       Local: 'São Paulo'
    //     }
    // ]

  }

}
