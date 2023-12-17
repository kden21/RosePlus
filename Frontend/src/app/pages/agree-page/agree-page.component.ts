import { Component } from '@angular/core';
import {GlobalVariable} from "../../global";

@Component({
  selector: 'app-agree-page',
  templateUrl: './agree-page.component.html',
  styleUrls: ['./agree-page.component.less']
})
export class AgreePageComponent {
  globalVariable = GlobalVariable;
}
