import { Component } from '@angular/core';
import { environment } from "../../../environments/environment";

@Component({
  selector: 'app-agree-page',
  templateUrl: './agree-page.component.html',
  styleUrls: ['./agree-page.component.less']
})
export class AgreePageComponent {
  environment = environment;
}
