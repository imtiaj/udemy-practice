import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

// import { BrowserAnimationsModule } from '@angular/platform-browser/animations';    
// import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { EmployeeInfoDetailComponent } from './employee-info-detail/employee-info-detail.component';
import { EmployeeBasicInfoService } from './shared/employee-basic-info.service';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeInfoDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    //BrowserAnimationsModule,  
    // ToastrModule.forRoot() 
  ],
  providers: [EmployeeBasicInfoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
