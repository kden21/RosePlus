import {Component, ViewChild} from '@angular/core';
import {NzCarouselComponent} from "ng-zorro-antd/carousel";
import {WindowService} from "../../services/WindowService";

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.less']
})
export class ContentComponent {
  @ViewChild(NzCarouselComponent) carouselRef: NzCarouselComponent | undefined;
  divStyle = 300;
  array = [1, 2, 3, 4];

  constructor(public windowService: WindowService) {
  }

}
