module Bowling.Tests

open Xunit
open FsUnit.Xunit
    
[<Fact>]
let ``12 strikes in row`` () =
    let expected = Some 300
    let actual = Bowling.bowlingScore "XXXXXXXXXXXX"
    actual |> should equal expected

[<Fact>]
let ``10 nines in row`` () =
    let expected = Some 90
    let actual = Bowling.bowlingScore "9-9-9-9-9-9-9-9-9-9-"
    actual |> should equal expected

[<Fact>]
let ``11 fives in row`` () =
    let expected = Some 150
    let actual = Bowling.bowlingScore "5/5/5/5/5/5/5/5/5/5/5"
    actual |> should equal expected

[<Fact>]
let ``custom case`` () =
    let expected = Some 187
    let actual = Bowling.bowlingScore "X9/5/72XXX9-8/9/X"
    actual |> should equal expected