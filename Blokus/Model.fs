module Blokus.Model

type Colour = 
    | Empty
    | Blue
    | Green 
    | Red
    | Yellow

type Omino = { Squares : bool [,] }

let Ominos = [
    // monomino
    {Squares = array2D [[ true ]]}
    // duomino
    {Squares = array2D [[ true; true ]]}
    // trionimoes
    {Squares = array2D [[ true; true; true ]]}
    {Squares = array2D [[ true; true]; [true; false]]}
    // tetronimoes
    {Squares = array2D [[ true; true; true; true ]]}
    {Squares = array2D [[ true; true]; [true; false]; [true; false]]}
    {Squares = array2D [[ true; false]; [true; true]; [true; false]]}
    {Squares = array2D [[ true; false]; [true; true]; [false; true]]}
    {Squares = array2D [[ true; true]; [true; true]]}
    // pentominoes
    {Squares = array2D [[ true; true; true; true; true ]]}
    {Squares = array2D [[ true; true]; [true; true]; [true; false]]}
    {Squares = array2D [[ true; true]; [true; false]; [true; true]]}
    {Squares = array2D [[ true; true]; [true; false]; [true; false]; [true; false]]}
    {Squares = array2D [[ true; false]; [true; true]; [false; true]; [false; true]]}
    {Squares = array2D [[ true; false]; [true; true]; [true; false]; [true; false]]}
    {Squares = array2D [[ true; true; true]; [true; false; false]; [true; false; false;]]}
    {Squares = array2D [[ true; true; true]; [false; true; false]; [false; true; false;]]}
    {Squares = array2D [[ true; true; false]; [false; true; false]; [false; true; true;]]}
    {Squares = array2D [[ true; true; false]; [false; true; true]; [false; true; false;]]}
    {Squares = array2D [[ true; true; false]; [false; true; true]; [false; false; true;]]}
    {Squares = array2D [[ false; true; false]; [true; true; true]; [false; true; false;]]}
    ]

let flatten array =
    let mutable result = []
    for x in 0..(Array2D.length1 array) - 1 do
        for y in 0..(Array2D.length2 array) - 1 do
            result <- (Array2D.get array x y) :: result 
    Seq.rev result

let areEquivalent array1 array2 = 
    Array2D.length1 array1 = Array2D.length1 array2
    && Array2D.length2 array1 = Array2D.length2 array2
    && Seq.forall2 (fun l r -> l = r) (flatten array1) (flatten array2)

type Board = {Squares : Colour [,] }

let initializeBoard x y =
    {Squares = Array2D.init x y (fun _ _ -> Empty)}

let replaceCell cells x y cell = 
    let newCells = Array2D.copy cells
    Array2D.set newCells x y cell
    newCells

let placeCell board x y cell =
    match board.Squares.[x,y] with
    | Empty -> {board with Squares = replaceCell board.Squares x y cell }
    | _ -> board

let InitialGameBoard = initializeBoard 20 20

