module Day04

open System
open Utils
open AoC2023.Inputs.Day04

let parseLine line =
    let cardToken, numbersToken = (splitBy2 ":" line)
    let cardNum = cardToken.Substring(5) |> int
    let winningToken, oursToken = splitBy2 "|" numbersToken
    let winningNumbers = winningToken |> splitIntsBySpaces |> Set.ofSeq
    let ourNumbers = oursToken |> splitIntsBySpaces |> Set.ofSeq
    (cardNum, winningNumbers, ourNumbers)

let scoreCard (cardNum, winningNumbers, ourNumbers) =
    let winningCount = Set.intersect winningNumbers ourNumbers |> Seq.length
    let score = Math.Pow(2, float (winningCount - 1)) |> int
    (score, winningCount, cardNum)

let parseAndScoreLine = parseLine >> scoreCard

let solve1 = splitInputByNewLines >> Seq.map parseAndScoreLine >> Seq.map fst3 >> Seq.sum

let countInstances = 
    let instanceFolder (prevInstanceCounts, prevAccumulatedInstances) curr =
        let score, winningCount, cardNum = parseAndScoreLine curr
        let instanceCount = Map.tryFind cardNum prevAccumulatedInstances |> default0 |> (+) 1
        let newInstances = [cardNum + 1..cardNum + winningCount]
        //Console.WriteLine("CardNum:{0}. Score:{1} Instances:{3} CardsToAdd:{4}", cardNum, score, winningCount, instances, newInstances)
        
        let accumulateInstances instances cardNum =
            let instanceAdder = default0 >> (+) (atLeast1 instanceCount) >> Some
            Map.change cardNum instanceAdder instances
        
        let accumulatedInstances = Seq.fold accumulateInstances prevAccumulatedInstances newInstances
        let instanceCounts = Map.add cardNum instanceCount prevInstanceCounts
        
        (instanceCounts, accumulatedInstances)
    
    Seq.fold instanceFolder (Map.empty, Map.empty) >> fst
    
let solve2 = splitInputByNewLines >> countInstances >> Map.values >> Seq.sum  

let print1 =
    Console.WriteLine(solve1 example1)
    Console.WriteLine(solve1 p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 example1)
    Console.WriteLine(solve2 p1)
    ()