import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { EmployeeInfoDetailComponent } from './employee-info-detail/employee-info-detail.component';
import { EmployeeBasicInfoComponent } from './employee-info-detail/employee-basic-info/employee-basic-info.component';
import { EmployeeBasicInfoDetailListComponent } from './employee-info-detail/employee-basic-info-detail-list/employee-basic-info-detail-list.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeInfoDetailComponent,
    EmployeeBasicInfoComponent,
    EmployeeBasicInfoDetailListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
