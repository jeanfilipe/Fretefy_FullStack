import { Injectable } from '@angular/core';
import { Observable, from, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RegionService {
  private statesUrl = 'http://localhost:5000/api/UFs';
  private citiesUrl = 'http://localhost:5000/api/cidade?uf=';
  private regioesUrl = 'http://localhost:5000/api/Regiao';
  private activeUrl = 'http://localhost:5000/api/Regiao/';
  private postUrl = 'http://localhost:5000/api/Regiao/create';

  constructor() {}

  getStates(): Observable<any> {
    return from(fetch(this.statesUrl).then(response => response.json()));
  }

  getCities(uf: string): Observable<any> {
    return from(fetch(this.citiesUrl + uf).then(response => response.json()));
  }

  getRegions(): Observable<any[]> {
    return from(fetch(this.regioesUrl).then(response => response.json()));
  }

  toggleActive(id: number, status: string): Observable<any> {
    const status_new = status === "Ativo" ? "Desativado" : "Ativo";
    return from(fetch(`${this.activeUrl}${id}/status/${status_new}`, {
      method: 'PUT'
    }).then(response => response.json()));
  }

  postRegiao(dados: any): Observable<any> {
    return from(fetch(this.postUrl, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(dados)
    }).then(response => {
      if (!response.ok) {
        // Se o status não for 2xx, lança um erro com o status e o texto do status
        return response.json().then(error => {
          throw new Error(`${response.status} - ${response.statusText}: ${JSON.stringify(error)}`);
        });
      }
      return response.json();
    }))
    .pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: any): Observable<never> {
    console.error('An error occurred', error);
    return throwError(error);
  }
}
