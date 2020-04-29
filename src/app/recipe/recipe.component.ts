import { Component, OnInit } from '@angular/core';
import { CookBookService } from '../cook-book.service';

@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {
  //2 way binding op input elementen om id & name te vinden en te kunnen opzoeken in de API.
  constructor(private cookBooksvc: CookBookService) { }

  ngOnInit() {
  }

}
