import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Appointment} from '../models/appointment';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class JournalService {

  constructor(private http: HttpClient) {
  }

  public GetJournal(): Observable<Appointment[]> {
    return this.http.get<Appointment[]>('https://localhost:5001/api/journal');
  }
}
