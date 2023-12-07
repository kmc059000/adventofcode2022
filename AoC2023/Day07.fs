module Day07
open Utils
open AoC2023.Inputs.Day07

type Hand = {
    handType : int
    values : int array
    bid: int
    rawHand : string
}

let valueMap = "23456789TJQKA".ToCharArray() |> Array.mapi (fun i c -> c, i) |> Map.ofArray

let parseHand (cards: string, bid : string) =
    let values =
        cards.ToCharArray()
        |> Array.map (flip Map.find valueMap)
    
    let rankGroups = values |> Seq.groupBy id |> Seq.map (Tuple2.mapSnd Seq.length) |> Seq.map snd |> Seq.sortByDescending id |> List.ofSeq
    
    let handType =
        match rankGroups with
        | [ 5 ] -> 7
        | [ 4; _ ] -> 6
        | [ 3; 2 ] -> 5
        | 3::_ -> 4
        | 2::2::_ -> 3
        | 2::_ -> 2
        | _ -> 1
        
    { handType = handType; values = values; bid = int bid; rawHand = cards }
     
let parseLine line =
    line
    |> splitBy2 " "
    |> parseHand

let parse = splitInputByNewLines >> Seq.map parseLine >> Seq.toList

let compareHands (h1 : Hand) (h2 : Hand) =
    match compare h1.handType h2.handType with
    | 0 -> compare h1.values h2.values
    | x -> x

let solve hands =
    hands
    |> Seq.sortWith compareHands
    |> Seq.mapi (fun i h -> i + 1, h)
    |> tapValues
    |> Seq.map (fun (rank,h) -> h.bid * rank)
    |> Seq.sum
    

let solve1 = parse >> solve
let solve2 _ = -1

let printAnswer = printAnswersWithSameInputs solve1 solve2 example1 p1