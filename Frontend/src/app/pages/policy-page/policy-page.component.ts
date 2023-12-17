import { Component } from '@angular/core';
import {GlobalVariable} from "../../global";

@Component({
  selector: 'app-policy-page',
  templateUrl: './policy-page.component.html',
  styleUrls: ['./policy-page.component.less']
})
export class PolicyPageComponent {
  globalVariable = GlobalVariable;
}
