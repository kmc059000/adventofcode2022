module Day04

open System
open Utils
open AoC2023.Inputs.Day04

let parseLine line =
    let mainTokens = (splitBy ":" line)
    let tokens = mainTokens[1] |> splitBy "|"
    let winningNumbers = tokens.[0] |> splitBy " " |> Array.map int |> Set.ofArray
    let ourNumbers = tokens.[1] |> splitBy " " |> Array.map int |> Set.ofArray
    let winningCount = ourNumbers |> Seq.filter (fun x -> Set.contains x winningNumbers) |> Seq.length
    let pow = (winningCount - 1)
    Math.Pow(2, pow) |> int

let solve1 = splitInputByNewLines >> Seq.map parseLine >> Seq.sum

let solve2 _ = ""

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()