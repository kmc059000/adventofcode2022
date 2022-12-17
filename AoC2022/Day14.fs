module Day14

open System
open AoC2022.Inputs.Day14
open Utils

type Cell = Empty | Rock | Sand


let parseCoords str =
    let tokens = splitBy "," str
    (int tokens[0], int tokens[1])
    
let expandPath (path1 : int*int,path2 : int*int) =
    match (path1,path2) with
    | (ax,ay),(bx,by) when ax = bx -> seq [for y in (Math.Min(ay, by))..(Math.Max(ay, by)) do (ax, y)]
    | (ax,ay),(bx,by) when ay = by -> seq [for x in (Math.Min(ax, bx))..(Math.Max(ax, bx)) do (x, ay)]
    | _ -> failwith "invalid input "
 

let parseLine = splitBy " -> " >> Seq.map parseCoords >> Seq.pairwise >> Seq.collect expandPath

let parseRocks = splitInputByNewLines >> Seq.collect parseLine >> Seq.map (fun x -> x,Rock) >> Map.ofSeq

let maxY<'a> = Map.keys >> Seq.map snd >> Seq.max
let maxX<'a> = Map.keys >> Seq.map fst >> Seq.max
let minX<'a> = Map.keys >> Seq.map fst >> Seq.min

let printState (map : Map<int*int,Cell>) =
    Console.WriteLine()
    Console.WriteLine()
    Console.WriteLine()
    for row in (map |> Map.keys |> Seq.map snd |> Seq.min)..(map |> Map.keys |> Seq.map snd |> Seq.max)
        do
                  let rowVal =
                      [for col in ((map |> Map.keys |> Seq.map fst |> Seq.min))..(map |> Map.keys |> Seq.map fst |> Seq.max) do
                          let pos = col,row
                          let cellValue = Map.tryFind pos map |> Option.defaultValue Empty
                          match cellValue with
                          | Empty -> "."
                          | Rock -> "#"
                          | Sand -> "o"
                          ]
                  
                  Console.WriteLine(String.Join("", rowVal))
              
              

let rec dropSand (state,count) maxY startingPos (x,y) =
    let nextPositions =
        [
            (x, y + 1)
            (x - 1, y + 1)
            (x + 1, y + 1)
        ]
        |> List.filter (fun x -> Option.isNone (Map.tryFind x state))
        
    if Map.containsKey startingPos state then (state,count)
    else if y = maxY + 1 || List.length nextPositions = 0 then
        let newState = Map.add (x,y) Sand state
        //printState newState |> ignore
        dropSand (newState,count + 1) maxY startingPos startingPos  
    else dropSand (state,count) maxY startingPos (List.head nextPositions) 
    

let sampleRocks = parseRocks sample1
let sampleMaxY = maxY sampleRocks

let inputRocks = parseRocks input1
let inputMaxY = maxY inputRocks


//let result = dropSand (inputRocks,0) inputMaxY (500,0) (500,0)

let print1 =
    //Console.WriteLine(result)
    ()


let addBottom state =
    let maxY = maxY state
    let minX = minX state
    let maxX = maxX state
    
    let additional = [for x in (minX - 200)..(maxX + 100) do (x, maxY + 2)]
    additional
    |> Seq.fold (fun map curr -> Map.add curr Rock map) state

let p2 input =
    let rocks = parseRocks input
    let result = dropSand (rocks,0) (maxY rocks) (500,0) (500,0)
    printState (fst result)
    result



let print2 =
    (Console.WriteLine(p2 input1 |> snd))
