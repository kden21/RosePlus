import { Component } from '@angular/core';
import {WindowSize} from "../../enums/WindowSize";
import {WindowService} from "../../services/window-service";
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-header-top',
  templateUrl: './header-top.component.html',
  styleUrls: ['./header-top.component.less']
})
export class HeaderTopComponent {
  environment = environment;
  windowSize = WindowSize;

  constructor(public windowService: WindowService) {
  }
}
