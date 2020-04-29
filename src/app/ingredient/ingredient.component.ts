import { Component, OnInit } from '@angular/core';
import { CookBookService } from '../cook-book.service';
@Component({
  selector: 'app-ingredient',
  templateUrl: './ingredient.component.html',
  styleUrls: ['./ingredient.component.css']
})
export class IngredientComponent implements OnInit {
  //2 way binding op input elementen om id & name te vinden en te kunnen opzoeken in de API.
  constructor(private cookBooksvc: CookBookService) { }

  ngOnInit() {
  }

}
