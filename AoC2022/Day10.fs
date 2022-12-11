module Day10

open System
open AoC2022.Inputs.Day10
open Utils

let cycles = [|20; 60; 100; 140; 180; 220|]

let execute v command startingCycle =
    match splitBy " " command with
    | [|"noop"|] -> [(startingCycle,v)],v
    | [|"addx"; num |] ->
        [ (startingCycle,v); (startingCycle + 1,v) ], (v + (int num))
    | _ -> failwith "cant interpret"

let executeAll (v : int) lines=
    let results,_,_ =
        lines
        |> Seq.fold (fun (currCycles : (int*int) list, v : int, cycle : int) curr ->
            let newCycles,newV = execute v curr cycle
            let allCycles = List.concat [newCycles; currCycles]
            let newCycleNum = cycle + List.length newCycles
            allCycles,newV,newCycleNum
            ) ([],1,1)
    
    let x =
        results
        |> Seq.filter (fun (cycleNum : int, _ : int) -> Seq.contains cycleNum cycles)
    [for a,b in x do
         Console.WriteLine(a.ToString() + "," + b.ToString() + " " + (a*b).ToString())] |> ignore
    
    x
    |> Seq.map (fun (x,y) -> x * y)
    |> Seq.fold (+) 0
    
    

let run = splitInputByNewLines >> executeAll 1

let print1 = printfn $"{run sample1} {run input1}"

let print2 = ignore