module Day02

open System
open AoC2022.Inputs

type Hand =
    | Rock
    | Paper
    | Scissors
    
type Outcome =
    | Win
    | Lose
    | Tie
    
let whoWon opponent me =
    match opponent, me with
    | (Rock, Paper) -> Win,me
    | (Rock, Scissors) -> Lose,me
    | (Paper, Scissors) -> Win,me
    | (Paper, Rock) -> Lose,me
    | (Scissors, Rock) -> Win,me
    | (Scissors, Paper) -> Lose,me
    | _ -> Tie,me
    
let score (outcome, hand) =
    let handScore = match hand with
                    | Rock -> 1
                    | Paper -> 2
                    | Scissors -> 3
    let winScore = match outcome with
                    | Win -> 6
                    | Lose -> 0
                    | Tie -> 3
    handScore + winScore
    

let parseHand (str : String) =
    let tokens = str.Split(" ")
    let opponent = match tokens[0] with
                   | "A" -> Rock
                   | "B" -> Paper
                   | "C" -> Scissors
                   | _ -> failwithf $"Could not read hand %s{tokens[0]}"
    let me = match tokens[1] with
             | "X" -> Rock
             | "Y" -> Paper
             | "Z" -> Scissors
             | _ -> failwithf $"Could not read hand %s{tokens[0]}"
    (opponent, me)

let hands (str: string) =
    str.Split("\n", StringSplitOptions.RemoveEmptyEntries)
    |> Array.map parseHand
    
let totalScore (str : string) =
    hands str
    |> Array.map (fun (opp,me) -> whoWon opp me)
    |> Array.map score
    |> Array.sum
    
let solveDay0201 = printfn $"%i{totalScore day0201}"




let parseCorrectHand (str : String) =
    let tokens = str.Split(" ")
    let opponent = match tokens[0] with
                   | "A" -> Rock
                   | "B" -> Paper
                   | "C" -> Scissors
                   | _ -> failwithf $"Could not read hand %s{tokens[0]}"
    let me = match tokens[1] with
             | "X" -> Lose
             | "Y" -> Tie
             | "Z" -> Win
             | _ -> failwithf $"Could not read hand %s{tokens[0]}"
    (opponent, me)

let chooseHand opponent me =
    match opponent, me with
    | (_, Tie) -> Tie,opponent
    | (Rock, Win) -> Win,Paper
    | (Rock, Lose) -> Lose,Scissors
    | (Paper, Win) -> Win,Scissors
    | (Paper, Lose) -> Lose,Rock
    | (Scissors, Win) -> Win,Rock
    | (Scissors, Lose) -> Lose,Paper    

let parseHands2 (str: string) =
    str.Split("\n", StringSplitOptions.RemoveEmptyEntries)
    |> Array.map parseCorrectHand
    
let totalScore2 (str : string) =
    str
    |> parseHands2 
    |> Array.map (fun (opp,me) -> chooseHand opp me)
    |> Array.map score
    |> Array.sum
    
let solveDay0202 = printfn $"%i{totalScore2 day0201}"
