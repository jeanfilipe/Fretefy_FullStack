import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class RegionService {
  private statesUrl = 'http://localhost:5000/api/UFs';
  private citiesUrl = 'http://localhost:5000/api/cidade?uf=';
  private regioesUrl = 'http://localhost:5000/api/Regiao';
  private activeUrl = 'http://localhost:5000/api/Regiao/';

  

  constructor(private http: HttpClient) {}

  getStates(): Observable<any> {
    return this.http.get<any>(this.statesUrl);
  }

  getCities(uf): Observable<any> {
    return this.http.get<any>(this.citiesUrl + uf);
  }

  getRegions(): Observable<any[]> {
    return this.http.get<any[]>(this.regioesUrl);
  }

  toggleActive(id: number, status: string): Observable<any> {
    const status_new = status == "Ativo" ? "Desativado" : "Ativo";
    return this.http.put<any>(`${this.activeUrl}${id}/status/${status_new}`, {});
  }


  
}
