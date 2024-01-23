import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import { environment } from '../../environments/environment';
import {ResponseDto} from "../dto/response-dto";
import {HttpObserver} from "./http-observer";

@Injectable()
export class HttpService{

  constructor(private http: HttpClient){ }

  get<T>(path: string){
    return new HttpObserver<T>(this.http.get<ResponseDto<T>>(environment.api_url + path));
  }

  post<T>(path: string, body: any){
    return new HttpObserver<T>(this.http.post<ResponseDto<T>>(environment.api_url + path, body));
  }

  put<T>(path: string, body: any){
    return new HttpObserver<T>(this.http.put<ResponseDto<T>>(environment.api_url + path, body));
  }

  delete<T>(path: string){
    return new HttpObserver<T>(this.http.delete<ResponseDto<T>>(environment.api_url + path));
  }
}
