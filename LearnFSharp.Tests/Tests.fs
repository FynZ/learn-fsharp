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

[<Theory>]
[<InlineData(3, 27)>]
[<InlineData(4, 64)>]
[<InlineData(5, 125)>]
let ``Cubic`` (input, expected) =
    Assert.Equal(expected, cubic input)