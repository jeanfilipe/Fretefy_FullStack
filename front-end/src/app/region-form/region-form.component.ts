import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormArray } from '@angular/forms';
import { RegionService } from '../region.service';

@Component({
  selector: 'app-region-form',
  templateUrl: './region-form.component.html',
  styleUrls: ['./region-form.component.scss']
})
export class RegionFormComponent implements OnInit {
  regionForm: FormGroup;
  states: any[] = [];
  availableCities: any[] = [];

  constructor(private fb: FormBuilder, private regionService: RegionService) { }

  ngOnInit(): void {
    this.regionForm = this.fb.group({
      regionName: ['', [Validators.required]],
      state: ['', [Validators.required]],
      cities: this.fb.array([], [Validators.required])
    });

    this.loadStates();
  }

  get citiesArray(): FormArray {
    return this.regionForm.get('cities') as FormArray;
  }

  loadStates(): void {
    this.regionService.getStates().subscribe((data: any) => {
      this.states = data;
    });
  }

  loadCities(): void {
    debugger;
    const selectedState = this.regionForm.get('state').value;
    this.regionService.getCities(selectedState).subscribe((data: any) => {
      this.availableCities = data;
    });
  }

  addCity(cityId: string): void {
    const cityName = this.availableCities.find(city => city.id === cityId)?.nome;
    if (cityName && !this.citiesArray.controls.some(control => control.value === cityName)) {
      this.citiesArray.push(this.fb.control(cityName));
    }
  }

  removeCity(index: number): void {
    this.citiesArray.removeAt(index);
  }

  onSubmit(): void {
    if (this.regionForm.valid) {
      console.log(this.regionForm.value);
      // Lógica para enviar os dados para o backend
    }
  }
}
