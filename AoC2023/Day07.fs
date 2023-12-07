module Day07
open Utils
open AoC2023.Inputs.Day07

type Hand = {
    handType : int
    values : int list
    bid: int
    rawHand : string
}

let makeValueMap =
    Seq.ofArray
    >> Seq.mapi TupleExtras.from2
    >> Seq.map TupleExtras.swap
    >> Map.ofSeq

let valueMap1 = makeValueMap ("23456789TJQKA".ToCharArray())
let jokerValue = -1
let valueMap2 = makeValueMap ("J23456789TQKA".ToCharArray())
                |> Map.map (fun k v -> if k = 'J' then jokerValue else v)
                
let parseHand valueMap line =
    let cards, bid = splitBy2 " " line
    let cardValues = cards.ToCharArray() |> Seq.map (flip Map.find valueMap) |> List.ofSeq
    let jokers, nonJokers = List.partition ((=) jokerValue) cardValues
    
    let jokerCount = List.length jokers
    let rankGroups = nonJokers
                     |> Seq.groupBy id
                     |> Seq.map (snd >> Seq.length)
                     |> Seq.sortByDescending id
                     // the sequence needs at least one element in the case all cards are jokers and are filtered out
                     |> SeqExtras.defaultIfEmpty 0
                     // add the joker count to the largest group of cards. one pair + 2 jokers = 4 of a kind.
                     |> SeqExtras.mapFirst ((+) jokerCount)
                     |> List.ofSeq
    
    let handType =
        match rankGroups with
        | 5::_ -> 7
        | 4::_ -> 6
        | 3::2::_ -> 5
        | 3::_ -> 4
        | 2::2::_ -> 3
        | 2::_ -> 2
        | _ -> 1
        
    { handType = handType; values = cardValues; bid = int bid; rawHand = cards }
     
let parse handParser = splitInputByNewLines >> Seq.map handParser >> Seq.toList

let compareHands h1 h2 =
    match compare h1.handType h2.handType with
    | 0 -> compare h1.values h2.values
    | x -> x

let solve =
    Seq.sortWith compareHands
    >> Seq.mapi (fun rank h -> h.bid * (rank + 1))
    >> Seq.sum
    

let solve1 = parse (parseHand valueMap1) >> solve
let solve2 = parse (parseHand valueMap2) >> solve

let printAnswer = printAnswersWithSameInputs solve1 solve2 example1 p1