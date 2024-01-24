import {Injectable} from "@angular/core";
import {HttpService} from "./http-service";
import {CategoryDto} from "../dto/category-dto";

@Injectable()
export class CategoryService{

  routeName = "Category";

  constructor(private httpService: HttpService){ }

  getCategoryById(categoryId: number){
    const path = `${ this.routeName }/GetCategoryById/${ categoryId }`;
    return this.httpService.get<CategoryDto>(path);
  }

  getCategories(){
    const path = `${ this.routeName }/GetCategories`;
    return this.httpService.get<CategoryDto[]>(path);
  }

  addCategory(categoryDto: CategoryDto){
    const path = `${ this.routeName }/AddCategory`;
    return this.httpService.post<CategoryDto>(path, categoryDto);
  }

  updateCategory(categoryDto: CategoryDto){
    const path = `${ this.routeName }/UpdateCategory`;
    return this.httpService.put<CategoryDto>(path, categoryDto);
  }

  deleteCategory(categoryId : number){
    const path = `${ this.routeName }/DeleteCategory/${ categoryId }`;
    return this.httpService.delete<CategoryDto>(path);
  }
}
