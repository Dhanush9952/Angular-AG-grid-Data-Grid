import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AgGridModule } from 'ag-grid-angular';

import { AppComponent } from './app.component';
import { PdfViewerModule } from 'ng2-pdf-viewer';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule,
    AgGridModule.withComponents(null),
    PdfViewerModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
