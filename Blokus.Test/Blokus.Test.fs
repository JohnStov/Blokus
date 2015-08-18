namespace Blokus.Test

    module Tests =

        open NUnit.Framework
        open FsUnit

        [<Test>]
        let ``Simple test``() = true |> should not' (be False)
