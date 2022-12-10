module Day09

open System
open AoC2022.Inputs.Day09
open Utils

type Position = { x : int; y: int; }
type State = { head : Position; tail: Position; tailPositions: Set<Position> }

let origin = { x = 0; y = 0; }
let initialState = { head = origin; tail = origin; tailPositions = Set.ofList [origin] }

let parse str =
    str
    |> splitInputByNewLines
    |> Seq.map (splitBy " ")
    |> Seq.map (fun token -> token[0],int token[1])
    |> Seq.collect (fun (dir,count) ->
        [ for x in 0..(count - 1) do dir ]
        )
    

let moveHead dir state =
    let head = state.head
    let dX, dY =
        match dir with
        | "R" -> 1,0
        | "L" -> -1,0
        | "U" -> 0,1
        | "D" -> 0,-1
        | _ -> failwith "bad dir"
    { state with head = { x = head.x + dX; y = head.y + dY } }
    
let moveTail state =
    let relativePosition = state.head.x - state.tail.x, state.head.y - state.tail.y
    let dX, dY =
        match relativePosition with
        | 0,2 -> 0,1
        | 0,-2 -> 0,-1
        | 2,0 -> 1,0
        | -2,0 -> -1,0
        | 1,2 -> 1,1
        | 1,-2 -> 1,-1
        | -1,2 -> -1,1
        | -1,-2 -> -1,-1
        | 2,1 -> 1,1
        | -2,1 -> -1,1
        | 2,-1 -> 1,-1
        | -2,-1 -> -1,-1
        | _ -> 0,0
    let newTail = { x = state.tail.x + dX; y = state.tail.y + dY }
    let tailPosition = Set.add newTail state.tailPositions
    { state with tail = newTail; tailPositions = tailPosition }
    

let move state lines =
    lines
    |> Seq.fold (fun acc curr ->
        acc
        |> moveHead curr
        |> moveTail
        ) state

let countTails state = Set.count state.tailPositions

let solve1 = parse >> move initialState >> countTails
let print1 = printfn $"{solve1 sample1} {solve1 input1}"
  
    
let solve2 = parse >> move initialState >> countTails
let print2 = printfn $"{solve2 sample1} {solve2 input1}"