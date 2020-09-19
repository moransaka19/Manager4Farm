import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { JournalComponent } from './journal/journal.component';
import {HttpClientModule} from '@angular/common/http';
import {JournalService} from './journal/journal.service';

@NgModule({
  declarations: [
    AppComponent,
    JournalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [JournalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
