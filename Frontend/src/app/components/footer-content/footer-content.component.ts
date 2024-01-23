import { Component } from '@angular/core';
import {WindowSize} from "../../enums/WindowSize";
import {WindowService} from "../../services/window-service";
import { environment } from "../../../environments/environment";

@Component({
  selector: 'app-footer-content',
  templateUrl: './footer-content.component.html',
  styleUrls: ['./footer-content.component.less']
})
export class FooterContentComponent {
  environment = environment;
  windowSize = WindowSize;
  currentYear = new Date().getFullYear();

  constructor(public windowService: WindowService) {
  }
}
