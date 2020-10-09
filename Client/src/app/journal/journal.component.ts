import {Component, OnInit} from '@angular/core';
import {JournalService} from './journal.service';
import {Appointment} from '../models/appointment';
import {Observable} from 'rxjs';

@Component({
  selector: 'app-journal',
  templateUrl: './journal.component.html',
  styleUrls: ['./journal.component.scss']
})
export class JournalComponent implements OnInit {
  journals$: Observable<Appointment[]>;
  journals: Appointment[];
  tableColumns: string[];

  constructor(private journalService: JournalService) {
    this.tableColumns = ['Date', 'Patient', 'Procedure'];
  }

  ngOnInit(): void {
    this.journals$ = this.journalService.GetJournal();
  }

}
