import {Component, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {JournalService} from './journal.service';
import {Appointment} from '../models/appointment';
import {Observable} from 'rxjs';

@Component({
  selector: 'app-journal',
  templateUrl: './journal.component.html',
  styleUrls: ['./journal.component.scss']
})
export class JournalComponent implements OnInit {
  journal$: Observable<Appointment[]>;
  journals: Appointment[];

  constructor(private journalService: JournalService) {
  }

  ngOnInit(): void {
    this.journalService.GetJournal().subscribe(value => this.journals = value);
  }

  onClick(): void {
    console.log(this.journals);
  }

}
