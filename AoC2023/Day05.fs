module Day05

open System
open Utils
open AoC2023.Inputs.Day05

type NumMap = int64 * int64 * int64

let doMap value numMap =
    let (sourceStart, destStart, length) = numMap
    let sourceEnd = sourceStart + length
    let destEnd = destStart + length
    if value >= sourceStart && value < sourceEnd then
        let offset = value - sourceStart
        Some (destStart + offset)
    else
        None

let transition maps value =
    Seq.choose (doMap value) maps
    |> Seq.tryHead
    |> Option.defaultValue value
    
    

let parseLine (input : string) =
    let tokens = input |>  splitBy " " |> Seq.map int64 |> Seq.toList
    match tokens with
    | [destStart; sourceStart; length] -> NumMap (sourceStart, destStart, length)
    | _ -> failwith "Invalid input"

let parseMap = splitInputByNewLines >> Seq.skip 1 >> Seq.map parseLine >> Seq.toList

let seedParser1 str = str |> splitBy " " |> Seq.skip 1 |> Seq.map int64 |> List.ofSeq

let parseMaps seedParser (input:string[]) =
    let seeds = seedParser input.[0]
    let maps = input.[1l..] |> Seq.map parseMap |> List.ofSeq
    (seeds, maps)
    
let minLocation (maps : NumMap list list) seed =
    maps
    |> Seq.fold (fun acc currMap ->
           let next = transition currMap acc           
           //printfn $"%i{acc} -> %i{next}"
           next
    ) seed
    
    
let minLocationOfAllSeeds (seeds : int64 list, maps : NumMap list list) =
    Seq.map (minLocation maps) seeds |> Seq.min
    
let solve1 = splitInputByDoubleNewLines >> parseMaps seedParser1 >> minLocationOfAllSeeds

let seedParser2 str =
    let seedTokens = str |> splitBy " " |> Seq.skip 1 |> Seq.map int64 |> List.ofSeq
    let pairs = List.chunkBySize 2 seedTokens
    let seeds =
        [ for pair in pairs do
            let start = List.head pair
            let count = List.tail pair |> List.head
            for i in start..(start + count - 1L) do
                yield i ]
    Console.WriteLine (Seq.length seeds)
    Console.WriteLine (seeds |> Seq.map toString |> String.concat ", ")
    
    seeds
    
    
    

let solve2 = splitInputByDoubleNewLines >> parseMaps seedParser2 >> minLocationOfAllSeeds  

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()