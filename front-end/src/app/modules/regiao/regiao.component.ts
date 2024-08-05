import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormArray } from '@angular/forms';
import { RegionService } from '../../region.service';  // Certifique-se de que o caminho está correto

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  regionForm: FormGroup;
  states = [];
  cities = [];
  selectedCities = new Set();

  constructor(
    private fb: FormBuilder,
    private regionService: RegionService
  ) {}

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
    this.regionService.getCities("pr").subscribe(data => {
      this.cities = data;
    });
  }

  addCity(city) {
    if (!this.selectedCities.has(city)) {
      this.selectedCities.add(city);
      this.citiesArray.push(this.fb.control(city, Validators.required));
    }
  }

  removeCity(index: number) {
    this.selectedCities.delete(this.citiesArray.at(index).value);
    this.citiesArray.removeAt(index);
  }

  get citiesArray(): FormArray {
    return this.regionForm.get('cities') as FormArray;
  }

  onSubmit() {
    if (this.regionForm.valid) {
      console.log(this.regionForm.value);
    }
  }
}
