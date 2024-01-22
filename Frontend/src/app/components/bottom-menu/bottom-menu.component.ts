import { Component } from '@angular/core';
import {WindowService} from "../../services/WindowService";
import {WindowSize} from "../../enums/WindowSize";

@Component({
  selector: 'app-bottom-menu',
  templateUrl: './bottom-menu.component.html',
  styleUrls: ['./bottom-menu.component.less']
})
export class BottomMenuComponent {
  windowSize = WindowSize;

  constructor(public windowService: WindowService) {
  }
}
