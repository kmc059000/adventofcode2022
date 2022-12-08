module Day08

open System
open AoC2022.Inputs.Day08
open Utils

type Tree = { value : int; idx : int }
type Trees = Tree[][]

let makeTree v idx = { value = v; idx = idx }

let len (trees : Trees) = trees[0].Length
let count (trees : Trees) = len trees * Array.length trees

let parse str =
    str
    |> splitInputByNewLines
    |> Array.mapi (fun rowIdx row ->
        chars row
        |> Array.mapi (fun colIdx value ->
            makeTree (int value) (rowIdx * row.Length + colIdx))
        )
    

let countVisible (trees : Tree[]) =
    let visible,_,_ =
        Seq.fold (fun (visible, count,highest) curr ->
        if curr.value > highest then
            (curr :: visible, count + 1, curr.value)
        else
            (visible, count, highest)
        ) ([], 0, -1) trees
    visible    

let leftToRight (trees : Trees) (row : int)  = trees[row]
let rightToLeft (trees : Trees) (row : int) = leftToRight trees row |> Array.rev
let topToBottom (trees : Trees) (col : int) = trees |> Array.map (fun row -> row[col])
let bottomToTop (trees : Trees) (col : int) = topToBottom trees col |> Array.rev

let forLine fn1 fn2 (trees : Trees) (row : int) =
    let ltr =  fn1 trees row |> countVisible
    let rtl = fn2 trees row |> countVisible
    Seq.concat [ltr; rtl]
  
let visibleForRow = forLine leftToRight rightToLeft
let visibleForCol = forLine topToBottom bottomToTop

let forAllLines (fn : (int -> Tree seq)) count =
    [ for x in 0..(count - 1) do fn x ]
    |> Seq.concat
    |> Seq.distinct

let countAll (trees : Trees) =         
    let allRows = forAllLines (visibleForRow trees) trees.Length
    let allCols = forAllLines (visibleForCol trees) trees[0].Length
    
    let r = [allRows; allCols]
            |> Seq.concat
            |> Seq.distinct
            
    let printTree t = $"{t.value} - {t.idx}"
    Console.WriteLine((r |> Seq.sortBy (fun x -> x.idx) |> Seq.map printTree |> String.concat "\n"))
    
    r |> Seq.length
    
    

let solve1 = parse >> countAll
let print1 = printfn $"{solve1 sample1} {solve1 input1}"
    
let solve2 str = ""
let print2 = printfn $"{solve2 sample1} {solve2 input1}"