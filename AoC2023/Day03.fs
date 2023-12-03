module Day03

open System
open System.Text.RegularExpressions
open Utils
open AoC2023.Inputs.Day03

type Position = { row : int; column: int; }
type Number = { value : int; pos : Position }
type Symbol = { sym : string; pos : Position  }
type Board = { numbers : Number list; symbols : Symbol list; symbolMap : Map<Position, Symbol>  }

let pos row col = { row = row; column = col  }

let parseLine row str =
    let numbers = Regex("\d+").Matches(str) |> Seq.map (fun m -> { value = m.Value |> int; pos = pos row m.Index }) |> List.ofSeq
    let symbols = Regex("[^0-9.]").Matches(str) |> Seq.map (fun m -> { sym = m.Value; pos = pos row m.Index }) |> List.ofSeq
    let symbolMap = symbols |> Seq.map (fun s -> (s.pos, s)) |> Map.ofSeq
    { numbers = numbers; symbols = symbols; symbolMap = symbolMap }

let boardFromLines (lines : Board list) =
    let numbers = lines |> Seq.collect (_.numbers) |> List.ofSeq
    let symbols = lines |> Seq.collect (_.symbols) |> List.ofSeq
    let symbolMap = symbols |> Seq.map (fun s -> (s.pos, s)) |> Map.ofSeq
    { numbers = numbers; symbols = symbols; symbolMap = symbolMap }    
    
let parseBoard = Seq.mapi parseLine >> List.ofSeq >> boardFromLines

let isAdjacentToSymbol (symbolsMap: Map<Position, Symbol>) (number : Number) =
    let startCol = number.pos.column - 1
    let endCol = number.pos.column + number.value.ToString().Length
    let rows = [number.pos.row - 1; number.pos.row; number.pos.row + 1]
    let cols = [startCol..endCol]
    let positions =
        [for r in rows do
            for c in cols do
                yield pos r c]
    positions |> Seq.exists symbolsMap.ContainsKey

let numberNextToSymbol board =
    board.numbers
    |> List.filter (isAdjacentToSymbol board.symbolMap)
    //|> tapValues
    

let solve1 = splitInputByNewLines >> parseBoard >> numberNextToSymbol >> Seq.sumBy _.value

let solve2 _ = ""


let print1 =
    Console.WriteLine(solve1 day3p1example)
    Console.WriteLine(solve1 day3p1)
    ()
   
let print2 =
    Console.WriteLine(solve2 day3p2example)
    Console.WriteLine(solve2 day3p2)
    ()