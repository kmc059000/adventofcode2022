module Day06

open System
open Utils
open AoC2023.Inputs.Day06

let parseLineAsNumbers =
    splitByWhitespace
    >> SeqExtras.compactStrings
    >> Seq.map int64
    
let parseLineAsSingleNumber =
    splitByWhitespace
    >> SeqExtras.compactStrings
    >> String.concat ""
    >> int64
    >> Seq.replicate 1

let parse parseLine input =
    let parseLines =
        splitInputByNewLines
        >> Seq.map (splitBy ":" >> Array.item 1 >> parseLine)
        >> SeqExtras.pluckFirst2ToTuple
        
    input |> parseLines ||> Seq.zip

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