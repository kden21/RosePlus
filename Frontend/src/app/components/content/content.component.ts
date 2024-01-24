import {Component, ViewChild} from '@angular/core';
import {NzCarouselComponent} from "ng-zorro-antd/carousel";
import {WindowService} from "../../services/window-service";
import {CategoryService} from "../../services/category-service";

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.less']
})
export class ContentComponent {
  @ViewChild(NzCarouselComponent) carouselRef: NzCarouselComponent | undefined;
  divStyle = 300;
  array = [1, 2, 3, 4];

  constructor(public windowService: WindowService, private categoryService: CategoryService) {
    /*categoryService.getCategories().subscribe({
                                                        next: (categories) => {console.log(categories)},
                                                        error: (error) => {console.log(error)}})*/
    categoryService.getCategoryById(-1).subscribe((response) => console.log(response));
  }

}
