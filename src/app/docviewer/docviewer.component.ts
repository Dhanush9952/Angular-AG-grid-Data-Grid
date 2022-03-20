import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-docviewer',
  templateUrl: './docviewer.component.html',
  styleUrls: ['./docviewer.component.css']
})
export class DocviewerComponent implements OnInit {

  viewer = 'google';  
  selectedType = 'docx';   
  DemoDoc="http://www.africau.edu/images/default/sample.pdf"  
  
  constructor() { }

  ngOnInit(): void {
  }

}
