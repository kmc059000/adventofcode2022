module Day03

open System
open AoC2022.Inputs

let scores = "_abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
let getScore (item : char) = scores.IndexOf(item)
let toCharArray (str : string) = str.ToCharArray()
let toLetterSet (str : string) = str |> toCharArray |> Set.ofArray

let answer1 (input : string) =
    input
    |> splitInputByNewLines
    |> Array.map (fun line ->
            [| line.Substring(0, line.Length / 2); line.Substring(line.Length / 2) |]
            |> Array.map toLetterSet
            |> Set.intersectMany
            |> Seq.head
            |> getScore
        )
    |> Array.sum

let solveDay0301 = printfn $"%i{answer1 day0301sample} %i{answer1 day0301}"

let answer2 (input : string) =
    let scoreForGroup sacks =
        sacks
        |> Array.map toLetterSet
        |> Set.intersectMany
        |> Seq.head
        |> getScore
        
    input
    |> splitInputByNewLines
    |> Array.chunkBySize 3
    |> Array.map scoreForGroup
    |> Array.sum
    
let solveDay0302 = printfn $"%i{answer2 day0301sample} %i{answer2 day0301}"
