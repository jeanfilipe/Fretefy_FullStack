import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeModule } from './modules/home/home.module';
import { ToolbarModule } from './components/toolbar/toolbar.module';
import { RouterModule } from '@angular/router';
import { RegionFormComponent } from './region-form/region-form.component';
import { RegiaoModule } from './modules/regiao/regiao.module';
import { HttpClientModule } from '@angular/common/http';
import { RegionListComponent } from './region-list/region-list.component';
@NgModule({
  declarations: [
    AppComponent,
    RegionFormComponent,
    RegionListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    HomeModule,
    ToolbarModule,
    RegiaoModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
