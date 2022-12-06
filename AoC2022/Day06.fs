module Day06

open System
open System.Collections.Generic
open AoC2022.Inputs
open Utils

let findStart (len : int) (str : String) =
    Seq.fold (fun acc curr ->
        let value, currentIndex = acc
        match value, currentIndex with
        | Some _, _ -> acc
        | None, i when i < (len - 1) -> (None, currentIndex + 1)
        | None, _ ->
            let count = str.Substring(currentIndex - (len - 1), len).ToCharArray() |> Set.ofArray |> Set.count
            if count = len then (Some currentIndex, currentIndex + 1) else (None, currentIndex + 1)            
        | _ -> failwith "todo"
        ) (None, 0) str |> snd

let betterFindStart (len : int) (str : string) =
    let startIdx = str.ToCharArray()
                   |> Seq.windowed len
                   |> Seq.findIndex (fun x -> len = (x |> Seq.distinct |> Seq.length))
    startIdx + len

let problem1 = betterFindStart 4

let a1samples =
    day0601sample
    |> Array.map problem1
    |> joinInts " "

let a1 = problem1 day0601

let solveDay0601 = printfn $"{a1samples} {a1}"

let problem2 = betterFindStart 14

let a2samples =
    day0601sample
    |> Array.map (problem2)
    |> joinInts " "

let a2 = problem2 day0601

let solveDay0602 = printfn $"{a2samples} {a2}"