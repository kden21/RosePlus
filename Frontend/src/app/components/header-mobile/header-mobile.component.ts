import {Component, ElementRef, ViewChild} from '@angular/core';
import {SearchComponent} from "../search/search.component";
import { environment } from "../../../environments/environment";

@Component({
  selector: 'app-header-mobile',
  templateUrl: './header-mobile.component.html',
  styleUrls: ['./header-mobile.component.less']
})
export class HeaderMobileComponent {
  environment = environment;
  @ViewChild('search') search: SearchComponent | undefined;
}
