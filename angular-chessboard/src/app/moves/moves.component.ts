import { Component, OnInit } from '@angular/core';
import { knightService } from '../knight.service';
import { Knight } from '../knight';
import { ChessBoard } from '../chessBoard';

@Component({
  selector: 'app-moves',
  templateUrl: './moves.component.html',
  styleUrls: ['./moves.component.css']
})
export class MovesComponent implements OnInit {

  whiteKnight: Knight = {
    coordx: 'h',
    coordy: 1,
    possibleMoves: [],
    color: 'white'
  }

  blackKnight: Knight = {
    coordx: 'a',
    coordy: 1,
    possibleMoves: [],
    color: 'black'
  }

  chess: ChessBoard = {
    rows: Array<number>(8, 7, 6 ,5 ,4 ,3 ,2 ,1),
    columns: Array<string>("a", "b", "c", "d", "e", "f", "g", "h")
  }

  
  constructor(private knightService: knightService) { }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.verifyPossibleMoves(this.whiteKnight);
    this.verifyPossibleMoves(this.blackKnight);
  }

  verifyPossibleMoves(knight: Knight): void {
    var $this = this;
    this.knightService.getPositions(knight.coordx, knight.coordy)
      .subscribe(
          data => knight.possibleMoves = data.possibleMoves,
          error => console.log("Error: ", error),
          function() {
            $this.placeKnight(knight);
            $this.placePossiblesMoves(knight);
          }
      );
    
  }

  placeKnight(knight: Knight): void {
    Array.from(document.getElementsByClassName(`knight-${knight.color}`)).forEach(element => {
      element.className = '';
    });
    var $knight = document.getElementById(`${knight.coordx}${knight.coordy}`);
    $knight.className = `knight-${knight.color}`;
  }

  placePossiblesMoves(knight: Knight): void {
    Array.from(document.getElementsByClassName(`${knight.color}-mark`)).forEach(element => {
      element.className = '';
    });
    knight.possibleMoves.forEach(element => {
      var $knight = document.getElementById(`${element.coordx}${element.coordy}`);
      $knight.className = `${knight.color}-mark`;
    });
  }

}
