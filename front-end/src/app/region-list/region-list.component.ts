import { Component, OnInit } from '@angular/core';
import { RegionService } from '../region.service';  // Certifique-se de que o caminho está correto
import { Observable } from 'rxjs';

@Component({
  selector: 'app-region-list',
  templateUrl: './region-list.component.html',
  styleUrls: ['./region-list.component.scss']
})
export class RegionListComponent implements OnInit {

  regions: any[] = [];

  constructor(private regionService: RegionService) { }

  ngOnInit(): void {
    this.regionService.getRegions().subscribe(
      (data) => this.regions = data,
      (error) => console.error('Erro ao carregar regiões', error)
    );
  }

  toggleActive(region: any): void {
    this.regionService.toggleActive(region.Id, region.Ativo).subscribe(
      (data) => region.Ativo = data.Ativo,
      (error) => console.error('Erro ao ativar/desativar a região', error)
    );
  }

}
