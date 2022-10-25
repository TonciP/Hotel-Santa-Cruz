import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-slider-nav',
  templateUrl: './slider-nav.component.html',
  styleUrls: ['./slider-nav.component.css']
})
export class SliderNavComponent implements OnInit {
  @Input() shouldRun = false;
  //@Input('boolean-attribute') shouldRun = true;

  constructor() { }

  ngOnInit(): void {
    console.log(this.shouldRun);
  }

}
