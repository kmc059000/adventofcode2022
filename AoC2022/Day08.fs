module Day08

open System
open AoC2022.Inputs.Day08
open Utils

type Tree = { value : int; idx : int }
type Trees = Tree[][]

module Trees =
    let makeTree v idx = { value = v; idx = idx }
    let all (trees : Trees) = Array.collect id trees
    
    
let len (trees : Trees) = trees[0].Length
let count (trees : Trees) = len trees * Array.length trees

let parse str =
    str
    |> splitInputByNewLines
    |> Array.mapi (fun rowIdx row ->
        chars row
        |> Array.mapi (fun colIdx value ->
            Trees.makeTree (int value) (rowIdx * row.Length + colIdx))
        )
    

let countVisible (startingHeight : int) (trees : Tree seq) =
    let visible,_,_ =
        Seq.fold (fun (visible, count,highest) curr ->
        if curr.value > highest then
            (curr :: visible, count + 1, curr.value)
        else
            (visible, count, highest)
        ) ([], 0, startingHeight) trees
    visible    

let leftToRight (trees : Trees) (row : int)  = trees[row]
let rightToLeft (trees : Trees) (row : int) = leftToRight trees row |> Array.rev
let topToBottom (trees : Trees) (col : int) = trees |> Array.map (fun row -> row[col])
let bottomToTop (trees : Trees) (col : int) = topToBottom trees col |> Array.rev

let forLine fn1 fn2 (trees : Trees) (row : int) =
    let ltr =  fn1 trees row |> countVisible -1
    let rtl = fn2 trees row |> countVisible -1
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
            
    // let printTree t = $"{t.value} - {t.idx}"
    // Console.WriteLine((r |> Seq.sortBy (fun x -> x.idx) |> Seq.map printTree |> String.concat "\n"))
    
    r |> Seq.length
    
    

let solve1 = parse >> countAll
let print1 = printfn $"{solve1 sample1} {solve1 input1}"
  
  


let countVisibleFromTree (tree : Tree) (trees : Tree seq) =
    let visible,_,_ =
        Seq.fold
          (fun (count, highest, cont) curr ->
                if not cont then
                    (count, highest, cont)
                else
                    (count + 1, Math.Max(highest, curr.value), curr.value < highest)
            ) (0, tree.value, true) trees
    visible


let getTree (trees : Trees) row col =
    let idx = row * trees.Length + col
    trees[row][col]


let countUp (trees : Trees) tree =
   let treeRow = tree.idx / trees.Length
   let col = tree.idx % trees.Length
   let treesToTry = [ for row in 0..Math.Max(0, treeRow - 1) do getTree trees row col ] |> List.except [tree] |> List.rev
   countVisibleFromTree tree treesToTry
   
let countDown (trees : Trees) tree =
   let treeRow = tree.idx / trees.Length
   let col = tree.idx % trees.Length
   let treesToTry = [ for row in (treeRow + 1)..(trees.Length - 1) do getTree trees row col ] |> List.except [tree]
   countVisibleFromTree tree treesToTry

let countLeft (trees : Trees) tree =
   let row = tree.idx / trees.Length
   let treeCol = tree.idx % trees.Length
   let treesToTry = [ for x in 0..(treeCol - 1) do getTree trees row x ] |> List.except [tree] |> List.rev
   countVisibleFromTree tree treesToTry 
  
let countRight (trees : Trees) tree =
   let row = tree.idx / trees.Length
   let col = tree.idx % trees.Length
   let treesToTry = [ for x in (col + 1)..(trees[0].Length - 1) do getTree trees row x ] |> List.except [tree]
   countVisibleFromTree tree treesToTry   
      
let findBestView (trees : Trees) =
    let best =
        trees
        |> Trees.all
        |> Seq.fold (fun acc curr ->
            let _, bestScore = acc
            let up = countUp trees curr
            let down = countDown trees curr
            let left = countLeft trees curr
            let right = countRight trees curr
            
            let score = up * down * left * right
            
            if score > bestScore then
                Some curr, score
            else acc
            ) (None, -1)
    
    let printTree t = t |> Option.map (fun x -> $"{x.value} - {x.idx}")
    Console.WriteLine(printTree (fst best))
    
    snd best
  
    
let solve2 = parse >> findBestView
let print2 = printfn $"{solve2 sample1} {solve2 input1}"