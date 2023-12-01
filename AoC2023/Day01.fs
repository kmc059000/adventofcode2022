module Day01

open System
open Utils
open AoC2023.Inputs

type MatchCases = { MatchText : string; Value : int }
let makeMatchCases matchText value = { MatchText = matchText; Value = value }
let p1Cases = [1..9] |> Seq.map (fun x -> makeMatchCases (x.ToString()) x) |> Seq.toList
let p2Cases =
    [ "one"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine" ]
    |> List.mapi (fun i x -> makeMatchCases (x.ToString()) (i + 1))
    |> List.append p1Cases
    
let findMatch findIndex matchPicker cases str =
    cases
    |> List.map (fun x -> (findIndex x.MatchText str, x.Value))
    |> List.filter (fst >> isPositive)
    |> matchPicker fst
    |> snd
    
let firstMatch = findMatch indexOf List.minBy
let lastMatch = findMatch lastIndexOf List.maxBy

let calibrateLine cases str = (firstMatch cases str * 10) + (lastMatch cases str)
let calibrateLines calibrateLine = splitInputByNewLines >> Seq.sumBy calibrateLine

let solve1 = calibrateLines <| calibrateLine p1Cases
let solve2 = calibrateLines <| calibrateLine p2Cases

let print1 =
    Console.WriteLine(solve1 day1p1Example)
    Console.WriteLine(solve1 day1p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 day1p2example)
    Console.WriteLine(solve2 day1p1)
    ()