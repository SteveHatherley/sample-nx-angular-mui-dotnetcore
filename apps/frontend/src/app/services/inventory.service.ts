import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { InventoryItem } from '../inventory.interface';
import { AppConfig as cfg} from '../app.config';

@Injectable({ providedIn: 'root' })
export class InventoryService {
    apiUrl = cfg.API_HOST + cfg.INVENTORY_ITEMS_ENDPOINT

    public items:InventoryItem[] = []

    constructor(private http: HttpClient) { };

    getInventoryItems(): Observable<InventoryItem[]> {
        return this.http.get<InventoryItem[]>(this.apiUrl);
    }
}