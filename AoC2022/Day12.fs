module Day12

open System
open System.Collections.Generic
open System.Runtime.Serialization.Json
open AoC2022.Inputs.Day12
open Day09
open Microsoft.FSharp.Core
open Utils

type Position = { row: int; col: int }

type Cell = {
    position : Position
    height: int
    isStart : bool
    isEnd : bool
}

let heights = "abcdefghijklmnopqrstuvwxyz"

let makeCell row col (height : string) =
    let isStart = height = "S"
    let isEnd = height = "E"
    let h = heights.IndexOf(if isStart then "a" else if isEnd then "z" else height)
    
    { position = { row = row; col = col }
      height = h
      isStart = isStart
      isEnd = isEnd }

//let matchesAnyPosition cells positions = Seq.exists (fun c -> c = cell.position) positions 

let neighbors cell cells rows columns cond =
    let row = cell.position.row
    let col = cell.position.col
    let positions =
        [
            { row = row - 1; col = col }
            { row = row + 1; col = col }
            { row = row; col = col - 1 }
            { row = row; col = col + 1 }
        ]        
    positions
    |> Seq.map (fun p -> Map.tryFind p cells)
    |> Seq.choose id
    |> Seq.filter cond
    
let neighborsByCell (cells : Map<Position,Cell>) rows columns cond =
    cells
    |> Map.values
    |> Seq.map (fun x -> x, neighbors x cells rows columns (cond x) |> List.ofSeq)
    |> Map.ofSeq

let parseInput str =
    let cells =
        str
        |> splitInputByNewLines
        |> Array.mapi (fun row line -> line |> chars |> Array.mapi (makeCell row))
        |> Array.collect id
    let startCell = Array.find (fun x -> x.isStart) cells
    let endCell = Array.find (fun x -> x.isEnd) cells
    
    let rows = (str |> splitInputByNewLines).Length
    let columns = ((str |> splitInputByNewLines)[0]).Length
    
    cells,startCell,endCell,rows,columns

let djikstras cells (startCell : Cell) (endCell : Cell) rows columns =
    let cellsByPosition = cells |> Seq.map (fun c -> c.position,c) |> Map.ofSeq
    let neighbors = neighborsByCell cellsByPosition rows columns (fun x c -> c.height <= x.height + 1 )
    let mutable dist = cells |> Seq.map (fun c -> c.position,Int32.MaxValue) |> Map.ofSeq
    let mutable prev : Map<Position,Cell option> = cells |> Seq.map (fun c -> c.position,None) |> Map.ofSeq
    let mutable queue = cells |> Set.ofArray
    let mutable foundShortest = false
    
    dist <- Map.add startCell.position 0 dist 
    
    while not foundShortest && Set.count queue > 0 do        
        let u = queue |> Set.toSeq |> Seq.minBy (fun x -> dist[x.position])
        
        if u = endCell then
            foundShortest <- true
        else
            queue <- Set.remove u queue
            
            let cellNeighbors = Map.find u neighbors  |> Set.ofList
            let cellNeighborsInQueue = queue |> Set.filter (fun c -> Set.contains c cellNeighbors)
            
            for n in cellNeighborsInQueue do
                let alt = dist[u.position] + 1
                if alt < dist[n.position] then
                    dist <- Map.add n.position alt dist
                    prev <- Map.add n.position (Some u) prev
            
    let mutable path = List.empty
    let mutable u = Some endCell
    
    if endCell = startCell || (Map.tryFind endCell.position >> Option.isSome) prev then
        while Option.isSome u do
            path <- u :: path
            u <- Map.tryFind u.Value.position prev |> Option.flatten
        
    path


let shortestPath fn (cells,startCell,endCell,rows,columns) =
    fn cells startCell endCell rows columns
    |> List.length
    |> (-) 1
    |> (*) -1


let print1 =
    Console.WriteLine(sample1 |> parseInput |> shortestPath djikstras)
    Console.WriteLine(input1 |> parseInput |> shortestPath djikstras)
    ()
    
    
let scenicPath (cells : Cell[]) (startCell : Cell) (endCell:Cell) rows columns =
    let cellsByPosition = cells |> Seq.map (fun c -> c.position,c) |> Map.ofSeq
    let neighbors = neighborsByCell cellsByPosition rows columns (fun x potentialNeighbor -> potentialNeighbor.height >= x.height - 1 )
    
    let s = Queue<Cell>()
    s.Enqueue(endCell)
    let mutable discovered : Set<Cell> = Set.empty
    let mutable parents : Map<Cell, Cell> = Map.empty
    let mutable found : Cell option = None
    
    while s.Count > 0 do
        let v = s.Dequeue()
        if found.IsNone && not (Set.contains v discovered) then
            discovered <- Set.add v discovered
            let cellNeighbors = Map.find v neighbors
            let unvisitedCellNeighbors = cellNeighbors |> Seq.filter (fun c -> not (Set.contains c discovered))
            
            for n in unvisitedCellNeighbors do
                s.Enqueue(n)
                parents <- Map.add n v parents
                
                if n.height = 0 then
                    found <- Some n
                
    let mutable cur = found
    let mutable path = List.empty
    while cur.IsSome do
        path <- cur.Value :: path
        cur <- Map.tryFind cur.Value parents
        
    path
    
let print2 =
    Console.WriteLine(sample1 |> parseInput |> shortestPath scenicPath)
    Console.WriteLine(input1 |> parseInput |> shortestPath scenicPath)
    ()