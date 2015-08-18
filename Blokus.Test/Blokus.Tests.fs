namespace Blokus

    module Tests =

        open NUnit.Framework
        open FsUnit
        open Blokus.Model

        [<Test>]
        let ``Simple test``() = true |> should not' (be False)

        [<Test>]
        let ``Dependent test``() = add 10 10 |> should equal 20
