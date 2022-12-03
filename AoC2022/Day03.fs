module Day03

open System
open AoC2022.Inputs

let scores = "_abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
let answer1 (input : string) =
    input.Split("\n", StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun line ->
        let first = line.Substring(0, line.Length / 2).ToCharArray() |> Set.ofArray
        let second = line.Substring(line.Length / 2).ToCharArray() |> Set.ofArray
        let letter = Set.intersect first second |> Set.toSeq |> Seq.head
        let score = scores.IndexOf(letter.ToString())
        score
        )
    |> Array.sum

let solveDay0301 = printfn $"%i{answer1 day0301sample} %i{answer1 day0301}"
let solveDay0302 = printfn $"%i{-1}"
