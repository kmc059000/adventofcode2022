module Day02

open System
open Utils
open AoC2023.Inputs

type Game = { id: int; draws: Draw list }
and Draw = { red: int; green: int; blue: int }

let parseColors str =
    let tokens = splitBySpaces str
    (int tokens[0], tokens[1])

let parseDraw (str : string) =
    let colorsForDraw = splitByComma >> Seq.map parseColors >> Seq.toList <| str
    let matchesColor color = (snd >> (=) color)
    let pluckColor color = List.tryFind (matchesColor color) >> Option.map fst >> Option.defaultValue 0 <| colorsForDraw
    { red  = pluckColor "red"; green = pluckColor "green"; blue = pluckColor "blue" }
    
let parseLine str =
    let tokens = splitBy ":" str
    let id = replace "Game " "" >> int <| tokens[0]
    let draws = splitBy ";" >> Seq.map parseDraw >> Seq.toList <| tokens.[1]
    { id = id; draws = draws }

let p1Threshold = { red = 12; green = 13; blue = 14 }

let withinThreshold threshold draw =
    let within color = color draw <= color threshold
    within _.red && within _.green && within _.blue 

let gameWithinThreshold threshold = _.draws >> Seq.forall (withinThreshold threshold)
    
let solve1 =
    splitInputByNewLines
    >> Seq.map parseLine
    >> Seq.filter (gameWithinThreshold p1Threshold)
    >> Seq.sumBy _.id
    
let minimumPerColor (game : Game) =
     let pickColor = (flip Seq.map game.draws >> Seq.max)
     Seq.map pickColor [ _.red; _.green; _.blue ]
    
let linePower = parseLine >> minimumPerColor >> Seq.reduce (*)
let solve2 = splitInputByNewLines >> Seq.sumBy linePower

let print1 =
    Console.WriteLine(solve1 day2p1example)
    Console.WriteLine(solve1 day2p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 day2p1example)
    Console.WriteLine(solve2 day2p1)
    ()