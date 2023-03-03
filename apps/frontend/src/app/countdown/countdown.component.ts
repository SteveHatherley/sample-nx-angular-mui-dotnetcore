import { Component, OnChanges, SimpleChanges } from '@angular/core';
import { TimeRemaining } from '../timeremaining.interface';

@Component({
  selector: 'init-countdown',
  templateUrl: './countdown.component.html',
  styleUrls: ['./countdown.component.css'],
})
export class CountdownComponent implements OnChanges {
  // public now
  public remaining:TimeRemaining = {
    years: 0,
    months: 0,
    days: 0,
    hours: 0,
    minutes: 0,
    seconds:  0,
    done: false,
  }
  ngOnChanges(changes: SimpleChanges): void {
    this.remaining.years = 0; 
  }
}
