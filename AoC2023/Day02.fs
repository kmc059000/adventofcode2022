module Day02

open System
open Utils
open AoC2023.Inputs

type Color =
    Red | Green | Blue

type ColorDraw = Color*int

type Draw = {
    red: int
    green: int
    blue: int
}

type Game = {
    id: int
    draws: Draw list
}

let parseColorDraw str =
    let tokens = (splitBy " " str)
    let count = int tokens[0]
    let color = 
        match tokens[1] with
        | "red" -> Red
        | "blue" -> Blue
        | "green" -> Green
        | s -> failwith "todo"
    ColorDraw (color,count)

let parseDraw str =
    let colors =
        str
        |> splitBy ","
        |> Seq.map parseColorDraw
        |> Map.ofSeq
    let pluckColor color = Map.tryFind color colors |> Option.defaultValue 0 
    { red  = pluckColor Red
      green = pluckColor Green
      blue = pluckColor Blue }
    

let rec parseLine str =
    let tokens = splitBy ":" str
    let id = tokens[0] |> replace "Game " "" |> int
    let draws = tokens.[1]
                |> splitBy ";"
                |> Seq.map parseDraw
                |> Seq.toList
    {
        id = id
        draws = draws
    }

let p1Threshold = {
    red = 12
    green = 13
    blue = 14
}

let withinThreshold threshold draw =
    draw.red <= threshold.red && draw.green <= threshold.green && draw.blue <= threshold.blue

let gameWithinThreshold threshold game =
    game.draws |> Seq.forall (withinThreshold threshold)
    
let solve1 input =
    input 
    |> splitInputByNewLines
    |> Seq.map parseLine
    |> Seq.filter (gameWithinThreshold p1Threshold)
    |> Seq.sumBy _.id
    

let minCountForColor game colorMap  =
    game.draws
    |> Seq.map colorMap
    |> Seq.max

let minColors (game : Game) : Draw =
    let pick = minCountForColor game
    {
        red = (pick _.red)
        blue = (pick _.blue)
        green = (pick _.green)
    }
    
let solve2 input =
    input 
    |> splitInputByNewLines
    |> Seq.map parseLine
    |> Seq.map minColors
    |> Seq.map (fun x -> x.red * x.green * x.blue, x)
    //|> Seq.map tapValue
    |> Seq.sumBy fst

let print1 =
    Console.WriteLine(solve1 day2p1example)
    Console.WriteLine(solve1 day2p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 day2p1example)
    Console.WriteLine(solve2 day2p1)
    ()