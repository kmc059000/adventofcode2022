module Day03

open System
open System.Text.RegularExpressions
open Utils
open AoC2023.Inputs.Day03

type Position = { row : int; column: int; }
type Number = { value : int; pos : Position; length : int }
type Symbol = { sym : string; pos : Position  }
type Board = { numbers : Number list; symbols : Map<Position, Symbol>  }
let numRegex = Regex("\d+", RegexOptions.Compiled)
let symbolRegex = Regex("[^0-9.]", RegexOptions.Compiled)

let pos row col = { row = row; column = col  }

let matchToNumber row (m : Match) = { value = m.Value |> int; pos = pos row m.Index; length = m.Value.Length }
let matchToSymbol row (m : Match) = { sym = m.Value; pos = pos row m.Index }

let parseLine row str =
    let numbers = numRegex.Matches(str) |> Seq.map (matchToNumber row) |> List.ofSeq
    let symbols = symbolRegex.Matches(str) |> Seq.map (matchToSymbol row) |> Seq.map (toTuple (_.pos) id) |> Map.ofSeq
    { numbers = numbers; symbols = symbols }

let boardFromLines lines =
    let numbers = lines |> Seq.collect (_.numbers) |> List.ofSeq
    let symbols = lines |> Seq.collect (_.symbols >> _.Values) |> List.ofSeq
    let symbolMap = symbols |> Seq.map (toTuple (_.pos) id) |> Map.ofSeq
    { numbers = numbers; symbols = symbolMap }

let parseBoard = parseGrid parseLine boardFromLines

let isAdjacentToSymbol (symbolsMap: Map<Position, Symbol>) (number : Number) =
    [for row in [number.pos.row - 1..number.pos.row + 1] do
        for c in [number.pos.column - 1..number.pos.column + number.length] do
            yield pos row c]
    |> Seq.exists symbolsMap.ContainsKey

let isNumberNextToSymbol board = isAdjacentToSymbol board.symbols
let numbersNextToSymbol board = board.numbers |> List.filter (isNumberNextToSymbol board)
    
let isGear board symbol =
    let adjacentToThisSymbol = isNumberNextToSymbol { board with symbols = Map.ofList [symbol.pos, symbol] }
    match symbol.sym with
    | "*" ->
        let adjacentNumbers = board.numbers |> List.filter adjacentToThisSymbol
        if List.length adjacentNumbers = 2
        then Some (symbol, (adjacentNumbers |> Seq.map _.value |> Seq.reduce (*)))
        else None
    | _ -> None

let gearRatios board =
    board.symbols.Values
    |> Seq.choose (isGear board)
    |> Seq.map snd
    
let solve1 = parseBoard >> numbersNextToSymbol >> Seq.sumBy _.value

let solve2 = parseBoard >> gearRatios >> Seq.sum

let print1 =
    Console.WriteLine(solve1 day3p1example)
    Console.WriteLine(solve1 day3p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 day3p1example)
    Console.WriteLine(solve2 day3p1)
    ()