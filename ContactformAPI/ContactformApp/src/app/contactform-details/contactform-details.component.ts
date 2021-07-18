import { Component, OnInit } from '@angular/core';
import { ContactformDetailService } from '../shared/contactform-detail.service';
import { ContactformDetail } from '../shared/contactform-detail.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-contactform-details',
  templateUrl: './contactform-details.component.html',
  styles: [
  ]
})
export class ContactformDetailsComponent implements OnInit {

  constructor(public service: ContactformDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  populateForm(selectedRecord: ContactformDetail) {
    this.service.formData = Object.assign({}, selectedRecord);
  }
  

}

