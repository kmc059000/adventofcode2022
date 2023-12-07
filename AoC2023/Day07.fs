module Day07
open Utils
open AoC2023.Inputs.Day07

type Hand = {
    handType : int
    values : int array
    bid: int
    rawHand : string
}

let valueMap1 = "23456789TJQKA".ToCharArray() |> Array.mapi (fun i c -> c, i) |> Map.ofArray
let valueMap2 = "J23456789TQKA".ToCharArray() |> Array.mapi (fun i c -> c, i) |> Map.ofArray

let parseHand (useJokers: bool) valueMap (cards: string, bid : string) =
    let values =
        cards.ToCharArray()
        |> Array.map (flip Map.find valueMap)
    
    let jokerCount = values |> Seq.filter ((=) 0) |> Seq.length
    let newJokerCount = if useJokers then jokerCount else 0
    let exceptJokers = if useJokers then (<>) 0 else (fun _ -> true)
    let rankGroups = values
                     |> Seq.filter exceptJokers
                     |> Seq.groupBy id
                     |> Seq.map (Tuple2.mapSnd Seq.length)
                     |> Seq.map snd
                     |> Seq.sortByDescending id
                     |> List.ofSeq
                     |> defaultIfEmpty 0
    
    let improvedRankCounts =
        match rankGroups with
        | [head] -> [(head + newJokerCount)]
        | head::tail -> head + newJokerCount :: tail
        | _ -> failwith "todo"
    
    let handType =
        match improvedRankCounts with
        | 5::_ -> 7
        | 4::_ -> 6
        | 3::2::_ -> 5
        | 3::_ -> 4
        | 2::2::_ -> 3
        | 2::_ -> 2
        | _ -> 1
        
    { handType = handType; values = values; bid = int bid; rawHand = cards }
     
let parseLine (useJokers: bool) valueMap line =
    line
    |> splitBy2 " "
    |> parseHand useJokers valueMap

let parse (useJokers: bool) valueMap = splitInputByNewLines >> Seq.map (parseLine useJokers valueMap) >> Seq.toList

let compareHands (h1 : Hand) (h2 : Hand) =
    match compare h1.handType h2.handType with
    | 0 -> compare h1.values h2.values
    | x -> x

let solve hands =
    hands
    |> Seq.sortWith compareHands
    |> Seq.mapi (fun i h -> i + 1, h)
    |> Seq.map (fun (rank,h) -> h.bid * rank)
    |> Seq.sum
    

let solve1 = parse false valueMap1 >> solve
let solve2 = parse true valueMap2 >> solve

let printAnswer = printAnswersWithSameInputs solve1 solve2 example1 p1