import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CookBookService {
//All calls to the api happen here.


  constructor(private _http: HttpClient) { }

  CallAllRecipes(s: string){
    //return this._http.get<IRecipe>("Localhost...");
  }
}
