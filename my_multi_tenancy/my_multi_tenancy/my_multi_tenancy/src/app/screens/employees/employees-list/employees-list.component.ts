import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.scss']
})
export class EmployeesListComponent implements OnInit{

  public employees: Employee[] =[{id:"7d3dacdf-f811-41bc-be3c-5f419ace7f3d", name:"example 1",email:"example1@gmail.com",salary: 20000,phone: 203020201, department:"Sales"},
  {id: "4bd373b0-6a97-472b-9b62-515ea462bddb", name:"example 2",email:"example2@gmail.com",salary: 20000,phone: 203020202, department:"Executive"},
  {id:"f281599c-7fab-42c0-93da-0b41e5191505", name:"example 3",email:"example3@gmail.com",salary: 20000,phone: 203020203, department:"Marketing"},
  {id:"17233212-ba01-401e-9c2e-865655a08716", name:"example 4",email:"example4@gmail.com",salary: 20000,phone: 203020204, department:"Sales"},
  {id:"368ee65a-1a9b-44ac-b7cc-1b6ffd0f5cc2", name:"example 5",email:"example5@gmail.com",salary: 20000,phone: 203020205, department:"marketing"},
];

constructor()
{

}

ngOnInit(): void {
  
}
}
