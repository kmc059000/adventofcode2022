module Day06

open System
open Utils
open AoC2023.Inputs.Day06

let parseLineAsNumbers =
    splitByWhitespace
    >> SeqExtras.compactStrings
    >> Seq.map int64
    >> Seq.toList
    
let parseLineAsSingleNumber =
    splitByWhitespace
    >> SeqExtras.compactStrings
    >> String.concat ""
    >> int64
    >> List.replicate 1

let parse lineParser input =
    let parseIntoLines lineParser =
        splitInputByNewLines
        >> Seq.map (splitBy ":" >> Array.item 1 >> lineParser)
        >> SeqExtras.pluckFirst2ToTuple
        
    input |> parseIntoLines lineParser ||> List.zip

let calculateNumWays (time, distance) =
    let calculateDist speed = (time - speed) * (speed)
    seq { 0L..time }
    |> Seq.map calculateDist
    |> Seq.filter ((<) distance)
    |> Seq.length

let solve lineParser = parse lineParser >> Seq.map calculateNumWays >> Seq.reduce (*)

let solve1 = solve parseLineAsNumbers

let solve2 = solve parseLineAsSingleNumber

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()