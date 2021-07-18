import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { NgSelectModule } from '@ng-select/ng-select';
import { NgOptionHighlightModule } from '@ng-select/ng-option-highlight';

import { AppComponent } from './app.component';
import { ContactformDetailsComponent } from './contactform-details/contactform-details.component';
import { ContactformDetailFormComponent } from './contactform-details/contactform-detail-form/contactform-detail-form.component';
import { HttpClientModule } from '@angular/common/http';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { RecaptchaModule } from "ng-recaptcha";

@NgModule({
  declarations: [
    AppComponent,
    ContactformDetailsComponent,
    ContactformDetailFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule, 
    BrowserAnimationsModule,
    NgSelectModule, FormsModule,
    NgOptionHighlightModule,
    RecaptchaModule,
    NgxMaskModule.forRoot(),
    ToastrModule.forRoot()
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
