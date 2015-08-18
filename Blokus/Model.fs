module Blokus.Model

type Cell = 
    | Empty

type Board = {X : int; Y : int; Cells : Cell [,] }

let GameBoard = {X=20; Y=20; Cells = Array2D.init 20 20 (fun _ _ -> Empty) }

