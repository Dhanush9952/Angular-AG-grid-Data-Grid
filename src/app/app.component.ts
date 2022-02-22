import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AG-Grids';

  columnDefs = [
    {headerName: 'Make', field: 'make'},
    {headerName: 'Model', field: 'model'},
    {headerName: 'Price', field: 'price'},
    {headerName: 'Country', field: 'country'},
    {headerName: 'Year', field: 'year'},
];

rowData = [
    {make: 'Toyota', model: 'Celica', price: 35000, country: 'India', year: 2017},
    {make: 'Ford', model: 'Mondeo', price: 32000, country: 'Germany', year: 2015},
    {make: 'Porsche', model: 'Boxter', price: 72000, country: 'USA', year: 2018},
    {make: 'Audi', model:'Classic', price: 40000, country: 'India', year: 2019},
    {make: 'NULL', model:'NULL', price: 34000, country: 'China', year: 2016},
    {make: 'NULL', model:'NULL', price: 32000, country: 'China', year: 2014},
];
defaultColDef = {
  sortable: true,
  filter: true,
};
}
