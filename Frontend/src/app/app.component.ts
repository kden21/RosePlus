import {Component, ElementRef, ViewChild} from '@angular/core';
import {WindowService} from "./services/window-service";
import {WindowSize} from "./enums/WindowSize";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  @ViewChild('header_top') header_top: ElementRef | undefined;
  @ViewChild('header_search') header_search: ElementRef | undefined;
  @ViewChild('bottom_menu') bottom_menu: ElementRef | undefined;

  windowSize = WindowSize;

  scrollY = 0;

  constructor(public windowService: WindowService){
  }

  ngOnInit() {
    this.windowService.changeWindowSize(window.innerWidth);

    window.onresize = () => this.windowService.changeWindowSize(window.innerWidth);
    window.onscroll = () => this.scrollY = scrollY;
  }
}
