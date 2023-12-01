module Day01

open System
open Utils
open AoC2023.Inputs

type MatchCases = { MatchText : string; Value : int }
let p1Cases = [1..9] |> Seq.map (fun x -> { MatchText = x.ToString(); Value = x })
let p2Cases =
    let words = [ "one"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine" ] |> Seq.mapi (fun i x -> { MatchText = x.ToString(); Value = i + 1 })
    Seq.append p1Cases words |> Seq.toArray
    


let findMatch findIndex picker cases =
    cases
    |> Seq.map (fun x -> (findIndex x.MatchText, x.Value))
    |> Seq.filter (fun (idx, _) -> idx >= 0)
    |> picker fst
    |> snd
    
let firstMatch str = findMatch (indexOfFlipped str) Seq.minBy
let lastMatch str = findMatch (lastIndexOfFlipped str) Seq.maxBy

                
let lineCalibrationValue cases (str : string) : int =
    [ firstMatch str cases; lastMatch str cases ] |> Seq.map _.ToString() |> String.concat "" |> parseInt
    
let calibrateLine1 = lineCalibrationValue p1Cases
        
let calibrationValue (calibrate : string -> int) =
    splitInputByNewLines
    >> Seq.map calibrate
    >> Seq.sum
    
let problem1 = calibrationValue calibrateLine1

let print1 =
    Console.WriteLine(problem1 day1p1Example)
    Console.WriteLine(problem1 day1p1)
    ()
                
let lineCalibrationValue2 = lineCalibrationValue p2Cases
   
let print2 =
    Console.WriteLine(lineCalibrationValue2 "eightwothree")
    Console.WriteLine(calibrationValue lineCalibrationValue2 day1p2example)
    Console.WriteLine(calibrationValue lineCalibrationValue2 day1p1)
    ()