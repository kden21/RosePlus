import { Component } from '@angular/core';
import {WindowSize} from "../../enums/WindowSize";
import {WindowService} from "../../services/WindowService";
import {GlobalVariable} from "../../global";

@Component({
  selector: 'app-header-top',
  templateUrl: './header-top.component.html',
  styleUrls: ['./header-top.component.less']
})
export class HeaderTopComponent {
  globalVariable = GlobalVariable;
  windowSize = WindowSize;

  constructor(public windowService: WindowService) {
  }
}
