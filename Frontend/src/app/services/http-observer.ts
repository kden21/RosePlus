import {HttpClient} from "@angular/common/http";
import { environment } from '../../environments/environment';
import {ResponseDto} from "../dto/response-dto";
import {Observable} from "rxjs";

export class HttpObserver<T>{

  constructor(private observer: Observable<ResponseDto<T>>) {
  }

  subscribe(callback: (response: ResponseDto<T>) => any){
    this.observer.subscribe({
      next: (response) =>
        callback(response),
      error: (error: any) =>
        callback(new ResponseDto<T>(null, false))});
  }

}
