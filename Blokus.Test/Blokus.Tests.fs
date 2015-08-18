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
        let ``Origin cell is empty``() = 
            GameBoard.Cells.[0,0] |> should equal Empty
            
