import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, NavigationCancel } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecipeComponent } from './recipe/recipe.component';
import { IngredientComponent } from './ingredient/ingredient.component';
import { AuthorComponent } from './author/author.component';
import { NavigationComponent } from './navigation/navigation.component';


@NgModule({
  declarations: [
    AppComponent,
    RecipeComponent,
    IngredientComponent,
    AuthorComponent,
    NavigationComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      { path: "Recipes", component: RecipeComponent },
      { path: "Ingredients", component: IngredientComponent},
      { path: "Authors", component: AuthorComponent },
      
      {path: "" , redirectTo:"home", pathMatch:"full"}
    ]),
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
