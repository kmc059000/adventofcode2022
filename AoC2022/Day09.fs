module Day09

open System
open AoC2022.Inputs.Day09
open Utils

type Position = { x : int; y: int; }
type State = { head : Position; tail: Position; tailPositions: Position list }

let origin = { x = 0; y = 0; }
let initialState = { head = origin; tail = origin; tailPositions = [origin] }

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
        
        | 2,2 -> 1,1
        | 2,-2 -> 1,-1
        | -2,2 -> -1,1
        | -2,-2 -> -1,-1
        
        | _ -> 0,0
    let newTail = { x = state.tail.x + dX; y = state.tail.y + dY }
    let tailPosition = newTail :: state.tailPositions
    { state with tail = newTail; tailPositions = tailPosition }
    

let move state lines =
    lines
    |> Seq.fold (fun acc curr ->
        acc
        |> moveHead curr
        |> moveTail
        ) state

let countTails state =
    Console.WriteLine("\n\n******* TAIL POSITIONS *******")
    [ for p in state.tailPositions |> List.rev do
          Console.WriteLine(p.x.ToString() + "," + p.y.ToString()) ] |> ignore
    state.tailPositions |> (List.distinct >> List.length)

let solve1 = parse >> move initialState >> countTails
let print1 = ignore // printfn $"{solve1 sample1} {solve1 input1}"


let printRope (rope : State list) dir =
    Console.WriteLine("****************  " +  dir)
    [for s in rope do
         Console.WriteLine(s.head.x.ToString() + "," + s.head.y.ToString() + "\t\t" + s.tail.x.ToString() + "," + s.tail.y.ToString() )]

//n - 2.
// 1 is for length -1 as is typical for for/in statements
let makeKnots n = [ for x in 0..(n-1) do initialState ] |> List.ofSeq

let rec moveRope (tails : State list) dir (newPositions : State list)  =
    match tails, newPositions with
    | [], _ -> newPositions |> List.rev
    | x :: xs, [] ->
        moveRope xs dir [(moveTail x)]
    | x :: xs, _ ->
        let curr = { x with head = newPositions.Head.tail }
        let newCurr = moveTail curr
        moveRope xs dir (newCurr :: newPositions)

let moveAll (state : State list) lines =
    lines
    |> Seq.fold (fun (acc : State list) (curr : string) ->
        let newHead = moveHead curr (List.head acc)
        let rope = newHead :: (List.tail acc)
        let r = moveRope rope curr []
        printRope r curr |> ignore
        r
        ) state

let solve2 knots = parse >> moveAll (makeKnots knots) >> List.last >> countTails
let print2 = printfn $"{solve2 9 sample2} {solve2 9 input1}"