module Day05

open System
open System.Collections.Generic
open AoC2022.Inputs
open Utils

type Move = { source : int; dest: int; count: int }

let parseStacks (str : string) : string[] =
    let lines = str |> splitInputByNewLines
    
    [| for line in 0..(lines.Length - 2) do
        [|for queue in 1..4..(lines[0].Length) do
                 (lines[line][queue]).ToString() |]
                 |> Array.filter (not << String.IsNullOrWhiteSpace) |]
    |> Seq.map Seq.rev
    |> Seq.map (String.concat "")
    |> Array.ofSeq

let parseMoves (str : string) : Move[] =
    str
    |> splitInputByNewLines
    |> Seq.map (splitBy " ")
    |> Seq.map (fun tokens ->
        {
            count = int tokens[1];
            source = int tokens[3];
            dest = int tokens[5];
        })
    |> Seq.toArray    

let parseInput (tokens : string[]) = (parseStacks tokens[0], parseMoves tokens[1])

let moveStacks (is9001 : bool) data =
    let stacks, moves = data |> splitInputByDoubleNewLines |> parseInput
    Array.fold (fun (stacks: string[]) (move : Move) ->
        let fromStack = stacks[move.source - 1]
        let toStack = stacks[move.dest - 1]
        let itemsToMove = fromStack.Substring(fromStack.Length - move.count)
        let pickedUpItems = if is9001 then itemsToMove else (itemsToMove |> reverse)  
        stacks[move.source - 1] <- fromStack.Substring(0, fromStack.Length - move.count)
        stacks[move.dest - 1] <- toStack + pickedUpItems
        stacks
    ) stacks moves
    
    
let tops (stacks : string[]) =
    stacks
    |> Array.map (fun s -> s[s.Length - 1].ToString())
    |> String.concat ""

let a1sample = moveStacks false day0501sample  |> tops
let a1 = moveStacks false day0501  |> tops

let solveDay0501 = printfn $"{a1sample} {a1}"


let a2sample = moveStacks true day0501sample  |> tops
let a2 = moveStacks true day0501  |> tops

let solveDay0502 = printfn $"{a2sample} {a2}"