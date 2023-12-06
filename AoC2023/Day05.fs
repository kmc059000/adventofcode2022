module Day05

open System
open System.IO
open Utils
open AoC2023.Inputs.Day05

type SeedRange = int64 * int64
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
    let seedRanges = List.pairwise seedTokens |> List.mapi (fun i seed -> (i, seed)) |> List.filter (fst >> isEven) |> List.map snd     
    seedRanges
    
    
let invertMaps (seeds, maps) =
    let invertMap (sourceStart, destStart, length) = (destStart, sourceStart, length)
    let invertedMaps =
        maps
        |> Seq.map (Seq.map invertMap >> Seq.toList)
        |> Seq.rev
        |> Seq.toList
    (seeds, invertedMaps)
    
let reverseMinLocationOfAllSeeds (seeds : SeedRange list, maps : NumMap list list) =
    let findSeed result =
        if result % 1000000L = 0L then Console.WriteLine($"trying {result}")
        let potentialSeed = minLocation maps result
        let found = seeds |> List.exists (fun (min, count) -> potentialSeed >= min && potentialSeed < min + count)
        if found then
            Console.WriteLine("Found !!!!!!!!!!!!!! " + result.ToString())
            Some result
        else None
    // i already ran everything from 0 to 27000000 and found nothing
    seq { 27000000L.. Int64.MaxValue }
    |> Seq.choose findSeed
    |> Seq.head

let reverseMinLocationOfAllSeedsParallel minrange maxrange chunkSize (seeds : SeedRange list, maps : NumMap list list) =
    let findSeed result =
        if result % 1000000L = 0L then Console.WriteLine($"trying {result}")
        let potentialSeed = minLocation maps result
        let found = seeds |> List.exists (fun (min, count) -> potentialSeed >= min && potentialSeed < min + count)
        if found then
            Console.WriteLine("Found !!!!!!!!!!!!!! " + result.ToString())
            Some result
        else None
        
    
    let findSeedsInChunk = Seq.choose findSeed >> Seq.tryHead
    let findSeedsInChunkAsync chunk = async { return findSeedsInChunk chunk }
    
    seq { minrange.. maxrange }
    |> Seq.chunkBySize chunkSize
    |> Seq.map findSeedsInChunkAsync
    |> Async.Parallel
    |> Async.RunSynchronously
    |> Seq.minBy (Option.defaultValue Int64.MaxValue)

let solve2 minrange maxrange chunkSize = splitInputByDoubleNewLines >> parseMaps seedParser2 >> invertMaps >> reverseMinLocationOfAllSeedsParallel minrange maxrange chunkSize

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 0L 1000L 10 example1)
    Console.WriteLine(solve2 0L 100_000_000 100_000 p1)
    ()