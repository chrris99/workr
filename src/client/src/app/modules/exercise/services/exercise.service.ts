import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Exercise } from '../models/exercise';

@Injectable({
  providedIn: 'root'
})
export class ExerciseService {
  baseUri: string = `${environment.backendUrl}/api/exercise`;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<HttpResponse<Exercise[]>> {
    const uri: string = this.baseUri;

    return this.http.get<HttpResponse<Exercise[]>>(uri);
  }

  public getById(id: string): Observable<HttpResponse<Exercise>> {
    const uri: string = `${this.baseUri}/${id}`;

    return this.http.get<HttpResponse<Exercise>>(uri);
  }

  public create(exercise: Exercise): Observable<HttpResponse<void>> {
    const uri: string = this.baseUri;
    return this.http.post<HttpResponse<void>>(uri, exercise);
  }

  public update(exercise: Exercise): Observable<HttpResponse<Exercise>> {
    const uri: string = `${this.baseUri}/${exercise.id}`;

    return this.http.post<HttpResponse<Exercise>>(uri, exercise);
  }

  public delete(id: string): Observable<HttpResponse<void>> {
    const uri: string = `${this.baseUri}/${id}`;
    return this.http.delete<HttpResponse<void>>(uri);
  }
}
