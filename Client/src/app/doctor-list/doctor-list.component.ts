import {Component, OnInit} from '@angular/core';
import {Observable} from 'rxjs';
import {Doctor} from '../models/doctor';
import {DoctorListService} from './doctor-list.service';

@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.scss']
})
export class DoctorListComponent implements OnInit {
  doctors$: Observable<Doctor>;

  constructor(private doctorListService: DoctorListService) {
  }

  ngOnInit(): void {
    this.doctors$ = this.doctorListService.GetDoctors();
  }

}
