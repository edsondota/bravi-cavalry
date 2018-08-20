import { Component, OnInit } from '@angular/core';
import { knightService } from '../knight.service';
import { Knight } from '../knight';

@Component({
  selector: 'app-moves',
  templateUrl: './moves.component.html',
  styleUrls: ['./moves.component.css']
})
export class MovesComponent implements OnInit {

  whiteKnight: Knight = {
    actualPos: {
      coordx: 'a',
      coordy: 1,
    },
    possibleMoves: [],
    color: 'white'
  }

  blackKnight: Knight = {
    actualPos: {
      coordx: 'a',
      coordy: 1,
    },
    possibleMoves: [],
    color: 'black'
  }
  
  constructor(private knightService: knightService) { }

  ngOnInit() {
  }

  verifyPossibleMoves(knight: Knight): void {
    this.knightService.getPositions(knight.actualPos.coordx, knight.actualPos.coordy)
      .subscribe(data => knight.possibleMoves = data.possibleMoves);
    console.log(knight)
  }

}
