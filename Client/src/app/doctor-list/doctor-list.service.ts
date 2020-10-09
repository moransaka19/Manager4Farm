import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {Doctor} from '../models/doctor';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DoctorListService {

  constructor(private http: HttpClient) {
  }
  // TODO: ADD URL
  public GetDoctors(): Observable<Doctor> {
    return this.http.get<Doctor>('');
  }
}
