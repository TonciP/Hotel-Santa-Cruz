import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatSliderModule } from '@angular/material/slider';
import { AppComponent } from './app.component';
import {MatButtonModule} from "@angular/material/button";
import {MatCardModule} from "@angular/material/card";
import {MatIconModule} from "@angular/material/icon";
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatSidenavModule} from "@angular/material/sidenav";
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import { SliderNavComponent } from './pages/slider-nav/slider-nav.component';
import {MatGridListModule} from "@angular/material/grid-list";
import {RouterModule, Routes} from "@angular/router";
import { FooterComponent } from './components/footer/footer.component';

const routes: Routes = [{path: '', component: SliderNavComponent }];

@NgModule({
  declarations: [
    AppComponent,
    SliderNavComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule,
    MatSliderModule,
    MatButtonModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    MatSidenavModule,
    BrowserAnimationsModule,
    MatGridListModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
