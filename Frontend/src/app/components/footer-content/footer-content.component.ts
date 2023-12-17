import { Component } from '@angular/core';
import {WindowSize} from "../../enums/WindowSize";
import {WindowService} from "../../services/WindowService";
import {GlobalVariable} from "../../global";

@Component({
  selector: 'app-footer-content',
  templateUrl: './footer-content.component.html',
  styleUrls: ['./footer-content.component.less']
})
export class FooterContentComponent {
  globalVariable = GlobalVariable;
  windowSize = WindowSize;
  currentYear = new Date().getFullYear();

  constructor(public windowService: WindowService) {
  }
}
