import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {JournalComponent} from './journal/journal.component';
import {DoctorComponent} from './doctor/doctor.component';

const routes: Routes = [
  {path: 'journal', component: JournalComponent},
  {path: 'doctor', component: DoctorComponent},
  {path: '', redirectTo: '/journal', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
