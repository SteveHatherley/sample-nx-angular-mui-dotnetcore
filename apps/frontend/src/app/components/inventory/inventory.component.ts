import { CommonModule } from '@angular/common';
import { Component, CUSTOM_ELEMENTS_SCHEMA, OnInit } from '@angular/core';
import { InventoryItem } from '../../inventory.interface';
import { InventoryService } from '../../services/inventory.service';

@Component({
  standalone: true,
  selector: 'init-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.css'],
  imports: [CommonModule]
})
export class InventoryComponent implements OnInit {
    public items : InventoryItem[] = [];

    constructor(private inventoryService: InventoryService) {}

    ngOnInit(): void {
        this.getInventoryItems();
    }

    getInventoryItems(): void {
        this.inventoryService.getInventoryItems().subscribe(items => this.items = items );
    }
}
