module Day05

open System
open Utils
open AoC2023.Inputs.Day05

let parseLine (input : string) =
    let tokens = input |>  splitBy " " |> Seq.map int64 |> Seq.toList
    let sourceStart, destStart, length =
        match tokens with
        | [destStart; sourceStart; length] -> (sourceStart, destStart, length)
        | _ -> failwith "Invalid input"
    
    Seq.zip [sourceStart..sourceStart + length] [destStart..destStart + length]
    |> Map.ofSeq

let parseMap: string -> Map<int64,int64> = splitInputByNewLines >> Seq.skip 1 >> Seq.map parseLine >> mergeManyMaps

let parseMaps (input:string[]) =
    let seeds = input[0l] |> splitBy " " |> Seq.skip 1 |> Seq.map int64 |> List.ofSeq
    let maps = input.[1l..] |> Seq.map parseMap |> List.ofSeq
    (seeds, maps)
    
let minLocation maps seed =
    maps
    |> Seq.fold (fun acc currMap ->
           let next = Map.tryFind acc currMap
                      |> Option.defaultValue acc
           
           printfn $"%i{acc} -> %i{next}"
           next
    ) seed
    
    
let minLocationOfAllSeeds (seeds : int64 list, maps : Map<int64, int64> list) =
    Seq.map (minLocation maps) seeds |> Seq.min
    
let solve1 = splitInputByDoubleNewLines >> parseMaps >> minLocationOfAllSeeds

let solve2 = splitInputByDoubleNewLines  

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()