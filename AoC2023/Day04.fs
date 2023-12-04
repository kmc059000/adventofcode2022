module Day04

open System
open Utils
open AoC2023.Inputs.Day04

let parseLine line =
    let mainTokens = (splitBy ":" line)
    let cardNum = mainTokens[0].Substring(5) |> int
    let numberTokens = mainTokens[1] |> splitBy "|"
    let winningNumbers = numberTokens.[0] |> splitBy " " |> Seq.map int |> Set.ofSeq
    let ourNumbers = numberTokens.[1] |> splitBy " " |> Seq.map int |> Set.ofSeq
    let winningCount = Set.intersect ourNumbers winningNumbers |> Seq.length
    let score = Math.Pow(2, float (winningCount - 1)) |> int
    (score, winningCount, cardNum)

let solve1 = splitInputByNewLines >> Seq.map parseLine >> Seq.map fst3 >> Seq.sum

let instanceFolder (instanceCounts, scoreMap) curr =
    let score, winningCount, cardNum = parseLine curr
    let instances = Map.tryFind cardNum scoreMap |> Option.defaultValue 0 |> (+) 1
    let cardsToAdd = [cardNum + 1..cardNum + winningCount]
    Console.WriteLine("CardNum:{0}. Score:{1} Instances:{3} CardsToAdd:{4}", cardNum, score, winningCount, instances, cardsToAdd) 
    let newMap =
         cardsToAdd
         |> Seq.fold (fun acc x -> Map.change x (fun valueOption -> Some ((Option.defaultValue 0 valueOption) + Math.Max(1, instances))) acc) scoreMap
    (Map.add cardNum instances instanceCounts, newMap)
    
let solve2 = splitInputByNewLines >> Seq.fold instanceFolder (Map.empty, Map.empty) >> fst >> Map.values >> Seq.sum  

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()