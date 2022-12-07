module Day04

open System
open AoC2022.Inputs
open Utils

let parseRange (str : string) = str.Split('-', ',') |> Array.map parseInt

let isSubset (tokens : int[]) =
        tokens[0] >= tokens[2] && tokens[1] <= tokens[3] || tokens[2] >= tokens[0] && tokens[3] <= tokens[1]

let isOverlapping (tokens : int[]) =
        tokens[0] <= tokens[3] && tokens[1] >= tokens[2] || tokens[3] <= tokens[0] && tokens[2] >= tokens[1]

let answer input filter = 
    input
    |> splitInputByNewLines
    |> Seq.map parseRange
    |> Seq.filter filter
    |> Seq.length
    
let solveDay0401 = printfn $"%i{answer day0401sample isSubset} %i{answer day0401 isSubset}"
    
let solveDay0402 = printfn $"%i{answer day0401sample isOverlapping} %i{answer day0401 isOverlapping}"