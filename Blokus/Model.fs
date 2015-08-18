module Blokus.Model

type Cell = 
    | Empty
    | Blue
    | Green 
    | Red
    | Yellow

type Board = {Cells : Cell [,] }

let initializeBoard x y =
    {Cells = Array2D.init x y (fun _ _ -> Empty)}

let replaceCell cells x y cell = 
    let newCells = Array2D.copy cells
    Array2D.set newCells x y cell
    newCells

let placeCell board x y cell =
    match board.Cells.[x,y] with
    | Empty -> {board with Cells = replaceCell board.Cells x y cell }
    | _ -> board

let InitialGameBoard = initializeBoard 20 20

