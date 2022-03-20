import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AgGridModule } from 'ag-grid-angular';

import { AppComponent } from './app.component';
import { PdfViewerModule } from 'ng2-pdf-viewer';
import { FormsModule } from '@angular/forms';
import { AComponent } from './a/a.component';
import { DocviewerComponent } from './docviewer/docviewer.component';
import { NgxDocViewerModule } from 'ngx-doc-viewer';

@NgModule({
  declarations: [
    AppComponent,
    AComponent,
    DocviewerComponent,

  ],
  imports: [
    BrowserModule,
    AgGridModule.withComponents(null),
    PdfViewerModule,
    FormsModule,
    NgxDocViewerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
