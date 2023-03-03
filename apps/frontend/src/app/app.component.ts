import { RouterModule } from '@angular/router';
import { Component } from '@angular/core';

import { MatToolbarModule } from '@angular/material/toolbar';
import { InventoryComponent } from './components/inventory/inventory.component';

@Component({
  // standalone: true,
  // imports: [MatToolbarModule, InventoryComponent, RouterModule],
  selector: 'init-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'frontend';
}
