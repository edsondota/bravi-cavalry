import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Knight } from './knight';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class knightService {

  private movesUrl = 'http://localhost:8080/Home/Knight';

  constructor(private http: HttpClient) { }

  getPositions(coordx: string, coordy: number): Observable<Knight> {
    return this.http.get<Knight>(`${this.movesUrl}?coordX=${coordx}&coordY=${coordy}`)
      .pipe(
        catchError(this.handleError('getKnight', []))
      );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
 
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
 
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
