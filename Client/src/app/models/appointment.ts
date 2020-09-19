export interface Appointment {
  appointmentId: number;
  date: Date;
  procedureId: number;
  procedureName: string;
  procedurePrise: number;
  doctorId: number;
  doctorJob: string;
  personId: number;
  personFirstname: string;
  personSurname: string;
  personDOB: Date;
}
