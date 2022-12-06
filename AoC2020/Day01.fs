module Day01

open System
open AoC2022.Inputs.Day01

let readInputToNumbers (words: string) = 
    words.Split('\r', '\n')
    |> Seq.ofArray
    |> Seq.map (fun w -> w.Trim())
    |> Seq.map int
    |> List.ofSeq

let combinations2 lst = 
    seq {
        for a in lst do
            for b in lst do
                if a <> b then
                    [a; b]
    }
    |> Seq.toList

let combinations3 lst = 
    seq {
        for a in lst do
            for b in lst do
                for c in lst do
                    if a <> b && a <> c then
                        [a; b; c]
    }
    |> Seq.toList

let sumIs2020 items = 
    let sum = items |> List.fold (+) 0
    match sum with
    | 2020 -> true
    | _ -> false

let product items = items |> List.fold (*) 1

let findSolution combiner rawInput = 
    rawInput 
    |> readInputToNumbers
    |> combiner
    |> Seq.filter sumIs2020
    |> Seq.head
    |> product


let findSolution2 = findSolution combinations2
let findSolution3 = findSolution combinations3


let a1sample = findSolution2 day01sample
let a1 = findSolution2 day01

let a2sample = findSolution3 day01sample
let a2 = findSolution3 day01

let solveDay0101 = printfn $"{a1sample} {a1}"
let solveDay0102 = printfn $"{a2sample} {a2}"