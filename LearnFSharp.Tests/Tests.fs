module Tests

open System
open Functions
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``Square`` () =
    Assert.Equal(4, square 2)