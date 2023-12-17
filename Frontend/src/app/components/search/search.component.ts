import { Component } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.less']
})
export class SearchComponent {
  searchFocused = false;

  searchItems : string[] = [];
  searchTempItems = ["Роза 1", "Роза 2", "Роза 3", "Роза 4", "Роза 5", "Роза 6", "Роза 7"];

  search(){
    alert("search");
  }

  searchChanged(e: any){
    this.searchItems = [];
    this.searchTempItems.forEach(item => {
      if (e.target.value.length !== 0 && item.toLowerCase().indexOf(e.target.value.toLowerCase()) > -1)
        this.searchItems.push(item);
    });
  }
}
