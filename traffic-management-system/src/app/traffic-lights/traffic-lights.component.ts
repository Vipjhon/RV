import { Component } from '@angular/core';

@Component({
  selector: 'app-traffic-lights',
  templateUrl: './traffic-lights.component.html',
  styleUrls: ['./traffic-lights.component.css']
})
export class TrafficLightsComponent {
  currentLight: string = 'red';

  changeLight() {
    if (this.currentLight === 'red') {
      this.currentLight = 'green';
    } else if (this.currentLight === 'green') {
      this.currentLight = 'yellow';
    } else {
      this.currentLight = 'red';
    }
  }
}
