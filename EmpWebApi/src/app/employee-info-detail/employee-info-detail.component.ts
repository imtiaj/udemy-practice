import { Component, OnInit } from '@angular/core';
import { EmployeeBasicInfoService } from '../shared/employee-basic-info.service';
import { EmployeeBasicInfo } from '../shared/employee-basic-info.model'
import { NgForm } from '@angular/forms';
import { from } from 'rxjs';
// import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employee-info-detail',
  templateUrl: './employee-info-detail.component.html',
  styles: []
})
export class EmployeeInfoDetailComponent implements OnInit {
  formData:EmployeeBasicInfo;
  empList: EmployeeBasicInfo[];
  Error:{};

  constructor(private service:EmployeeBasicInfoService) { }

  ngOnInit() {
    this.formData = new EmployeeBasicInfo();
    this.getAllEmployee();
  }

  resetForm(form ?: NgForm){
    if(form!=null)
      form.resetForm();
    this.service.formData = new EmployeeBasicInfo();
  }

  getAllEmployee(){    
    this.service.getEmployeeDetail().subscribe((res: EmployeeBasicInfo[]) => {      
      this.empList = res; 
    });
  }

  onSubmit(form:NgForm){    
    this.service.postEmployeeDetail(form.value).subscribe(
      res => {
        this.resetForm(form);
        this.getAllEmployee();
        // this.toastr.success('Employee Detail Register', 'Successfully registered!');
      },
      err => {        
        this.Error = err.error.errors;
        console.log(err.error.errors);
        // this.toastr.error(err); 
      }
    )
  }

  onDelete(email) {
    if (confirm('Are you sure to delete this record..?')) {      
      this.service.deleteEmployee(email)
        .subscribe(
          res => {
            debugger;
            this.getAllEmployee();
            // this.toastr.warning("Information deleted successfully!", "User delete process");
          },
          err => {
            console.log(err);
          }
        )
    }
  }

}
