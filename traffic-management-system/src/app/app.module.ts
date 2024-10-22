import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CityMapComponent } from './city-map/city-map.component';
import { TrafficLightsComponent } from './traffic-lights/traffic-lights.component';
import { DataAnalyticsComponent } from './data-analytics/data-analytics.component';
import { UserManagementComponent } from './user-management/user-management.component';

@NgModule({
  declarations: [
    AppComponent,
    CityMapComponent,
    TrafficLightsComponent,
    DataAnalyticsComponent,
    UserManagementComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
