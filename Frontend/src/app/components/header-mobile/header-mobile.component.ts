import {Component, ElementRef, ViewChild} from '@angular/core';
import {GlobalVariable} from "../../global";
import {SearchComponent} from "../search/search.component";

@Component({
  selector: 'app-header-mobile',
  templateUrl: './header-mobile.component.html',
  styleUrls: ['./header-mobile.component.less']
})
export class HeaderMobileComponent {
  globalVariable = GlobalVariable;
  @ViewChild('search') search: SearchComponent | undefined;
}
