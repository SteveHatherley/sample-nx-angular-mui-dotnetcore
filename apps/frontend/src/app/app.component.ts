import { RouterModule } from '@angular/router';
import { Component } from '@angular/core';

import { MatToolbarModule } from '@angular/material/toolbar';

@Component({
  standalone: true,
  imports: [MatToolbarModule, RouterModule],
  selector: 'init-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'frontend';
}
