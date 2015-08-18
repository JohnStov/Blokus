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
            
