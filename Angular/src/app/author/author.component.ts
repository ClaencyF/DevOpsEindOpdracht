import { Component, OnInit } from '@angular/core';
import { CookBookService } from '../cook-book.service';
@Component({
  selector: 'app-author',
  templateUrl: './author.component.html',
  styleUrls: ['./author.component.css']
})
export class AuthorComponent implements OnInit {
  //2 way binding op input elementen om id & name te vinden en te kunnen opzoeken in de API.
  constructor(private cookBooksvc: CookBookService) { }

  ngOnInit() {
  }

}
