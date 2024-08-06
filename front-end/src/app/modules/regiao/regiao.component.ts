import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormArray } from '@angular/forms';
import { RegionService } from '../../region.service';  // Certifique-se de que o caminho está correto
import { Router } from '@angular/router';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  regionForm: FormGroup;
  states = [];
  cities = [];
  availableCities: any[] = [];

  constructor(
    private fb: FormBuilder,
    private regionService: RegionService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.regionForm = this.fb.group({
      regionName: ['', [Validators.required]],
      state: ['', [Validators.required]],
      cities: this.fb.array([], Validators.required)
    });

    this.loadStates();
  }

  loadStates() {
    this.regionService.getStates().subscribe(data => {
      this.states = data;
    });
  }

  loadCities() {
    this.regionService.getCities(this.regionForm.value.state).subscribe(data => {
      this.cities = data;
    });
  }

  addCity(cityId: string): void {

    if (!this.citiesArray.controls.find(control => control.value == cityId)) {
      this.citiesArray.push(this.fb.control(cityId));
    }
  }

  removeCity(index: number) {
    this.citiesArray.removeAt(index);
  }

  get citiesArray(): FormArray {
    return this.regionForm.get('cities') as FormArray;
  }

  showMessage(message: string) {
    alert(message);
  }

  async onSubmit() {
    if (this.regionForm.valid) {
      try {
        let retorno = await this.regionService.postRegiao(this.regionForm.value).toPromise();

        // Navega para a lista de regiões após um breve atraso
        setTimeout(() => {
          this.router.navigate(['/regiao-list']);
        }, 3000);

        console.log(this.regionForm.value);

      } catch (error) {
        // Trata o erro e exibe uma mensagem na tela
        if (error.message.includes('400')) {
          this.showMessage('O item já existe.');
        } else {
          this.showMessage('O item já existe.');
        }
      }
    }
  }
}