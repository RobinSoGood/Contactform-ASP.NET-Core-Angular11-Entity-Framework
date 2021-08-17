import { Component, OnInit } from '@angular/core';
import { ContactformDetailService } from 'src/app/shared/contactform-detail.service';
import { NgForm } from '@angular/forms';
import { ContactformDetail } from 'src/app/shared/contactform-detail.model';
import { ToastrService } from 'ngx-toastr';
import { RecaptchaErrorParameters } from "ng-recaptcha"


@Component({
  selector: 'app-contactform-detail-form',
  templateUrl: './contactform-detail-form.component.html',
  styles: []
  
})


export class ContactformDetailFormComponent implements OnInit {

  siteKey: string;

  constructor(public service: ContactformDetailService, private toastr: ToastrService) { this.siteKey = '6Lcbjp0bAAAAAEWSOf0TWzNlZlgYYEHgodimRs9N';}
    public captchaResponse = "";

  public resolved(captchaResponse: string): void {
    const newResponse = captchaResponse
      ? `${captchaResponse.substr(0, 7)}...${captchaResponse.substr(-7)}`
      : captchaResponse;
    this.captchaResponse += `${JSON.stringify(newResponse)}\n`;
  }

  public onError(errorDetails: RecaptchaErrorParameters): void {
    this.captchaResponse += `ERROR; error details (if any) have been logged to console\n`;
    console.log(`reCAPTCHA error encountered; details:`, errorDetails);
  }
 


  simpleItems : string[] = [];


  ngOnInit() {  
    this.simpleItems = ['Тех.Поддержка', 'Продажи', 'Другое'];
    
  }

  onSubmit(form: NgForm) {
    this.showToastr();
    this.insertRecord(form);
  }
  showToastr(){
    var massiveOfValues = ['Имя:'+ " " + this.service.formData.name +'</br>Email:' + " " + this.service.formData.email + '</br>Телефон:' + " " + "+7" + this.service.formData.telephone + '</br>Тема:' + " " + this.service.formData.theme + '</br>Сообщение:' + " " + this.service.formData.message.slice(0, 10)]
    this.toastr.info(massiveOfValues.toString(),"", { closeButton: true, timeOut: 18000, progressBar: true, enableHtml: true });
    
  }

  insertRecord(form: NgForm) {
    this.service.postContactformDetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Форма отправлена', 'Успешно выполнено')
      },
      err => { console.log(err); }
    );
  }

  
  
  
  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new ContactformDetail();
  }

}

