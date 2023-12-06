module Day06

open System
open System.IO
open System.Text.RegularExpressions
open Utils
open AoC2023.Inputs.Day06


let parse input =
    let times, distances =
        splitInputByNewLines input
        |> Seq.map (splitBy ":")
        |> Seq.map (fun x -> x[1])
        |> Seq.map ((splitByRegex (Regex("\s+", RegexOptions.Compiled))) >> List.filter (String.IsNullOrEmpty >> not) >> (List.map int64))
        |> List.ofSeq
        |> takeAs2
    List.zip times distances

let calculateNumWays (time, distance) =
    let calculateDist speed = (time - speed) * (speed)
    tapValue <| "TIME: "+ time.ToString() |> ignore
    seq { 0L..time }
    |> Seq.map calculateDist
    |> Seq.filter ((<) distance)
    //|> tapValues2 time
    |> Seq.length
    |> tapValue

let solve1 = parse >> Seq.map calculateNumWays >> Seq.reduce (*)

let parse2 input =
    let times, distances =
        splitInputByNewLines input
        |> Seq.map (splitBy ":")
        |> Seq.map (fun x -> x[1])
        |> Seq.map ((splitByRegex (Regex("\s+", RegexOptions.Compiled))) >> List.filter (String.IsNullOrEmpty >> not) >> String.concat "" >> int64)
        |> List.ofSeq
        |> takeAs2
    [times,distances] |> tapValue

let solve2 = parse2 >> Seq.map calculateNumWays >> Seq.reduce (*)
let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()