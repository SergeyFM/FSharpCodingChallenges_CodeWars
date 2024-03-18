
namespace FSharpCodingChallenges_CodeWars

(*

7 kyu
Find min and max

Implement a function that returns the minimal and the maximal value of a list (in this order).

*)

module Katas =
    let getMinMax list =
        match list with
        | [] -> failwith "List's empty!"
        | _ -> (List.min list, List.max list)

open Microsoft.VisualStudio.TestTools.UnitTesting
open Katas

[<TestClass>]
type MinMaxTests() =
    
    [<TestMethod>]
    member this.``Test with single element list`` () =
        let expected = (1, 1)
        let actual = getMinMax [1]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.``Test with two elements list in order`` () =
        let expected = (1, 2)
        let actual = getMinMax [1; 2]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.``Test with two elements list in reverse order`` () =
        let expected = (1, 2)
        let actual = getMinMax [2; 1]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    [<ExpectedException(typeof<System.Exception>)>]
    member this.``Test with empty list`` () =
        let actual = getMinMax []
        Assert.AreEqual(true, false)

