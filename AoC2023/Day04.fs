module Day04

open System
open Utils
open AoC2023.Inputs.Day04

let parseLine line =
    let mainTokens = (splitBy ":" line)
    let cardNum = mainTokens[0].Substring(5) |> int
    let tokens = mainTokens[1] |> splitBy "|"
    let winningNumbers = tokens.[0] |> splitBy " " |> Array.map int |> Set.ofArray
    let ourNumbers = tokens.[1] |> splitBy " " |> Array.map int |> Set.ofArray
    let winningCount = ourNumbers |> Seq.filter (fun x -> Set.contains x winningNumbers) |> Seq.length
    let pow = (winningCount - 1)
    let score = Math.Pow(2, pow) |> int
    (score, winningCount, cardNum)

let solve1 = splitInputByNewLines >> Seq.map parseLine >> Seq.map (fun (score, _, _) -> score) >> Seq.sum

let instanceFolder (instanceCounts, scoreMap) curr =
    let (score, winningCount, cardNum) = parseLine curr
    let copies = Map.tryFind cardNum scoreMap |> Option.defaultValue 0
    let instances = copies + 1
    let cardScore = score * instances
    let cardToAdd = [cardNum + 1..cardNum + winningCount]
    Console.WriteLine("CardNum:{0}. Score:{1} Instances:{3} CopyScore:{4} CardsToAdd:{5}", cardNum, score, winningCount, instances, cardScore, cardToAdd) 
    let newMap =
         cardToAdd
         |> Seq.fold (fun acc x -> Map.change x (fun valueOption -> Some ((Option.defaultValue 0 valueOption) + Math.Max(1, instances))) acc) scoreMap
    (Map.add cardNum instances instanceCounts, newMap)
    
let solve2 input =
    let scores = splitInputByNewLines >> Seq.map parseLine <| input
    let instances = splitInputByNewLines >> Seq.fold instanceFolder (Map.empty, Map.empty) >> fst >> Map.values >> Seq.sum <| input
    instances  

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()