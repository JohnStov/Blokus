namespace Blokus

    module Tests =

        open NUnit.Framework
        open FsUnit
        open Blokus.Model

        [<Test>]
        let ``Game board X dimension is 20``() = 
            GameBoard.X |> should equal 20

        [<Test>]
        let ``Game board Y dimension is 20``() = 
            GameBoard.Y |> should equal 20

        [<Test>]
        let ``All cells are empty initially``() =
            for cell in GameBoard.Cells do
                cell |> should equal Empty
            
        let checkCellColour board x y cell = 
            board.Cells |> Array2D.iteri (fun cellX cellY value -> 
                if cellX = x && cellY = y                
                then value |> should equal cell 
                else value |> should equal Empty) 
        
        [<Test>]
        let ``Can place cell at 0,0 on empty board``() =
            let newboard = placeCell GameBoard 0 0 Red
            checkCellColour newboard 0 0 Red
                
        [<Test>]
        let ``Cannot place cell at 0,0 if it is already occupied``() =
            let board = placeCell GameBoard 0 0 Red
            let newboard = placeCell board 0 0 Blue
            checkCellColour newboard 0 0 Red

