module Day10

open System
open AoC2022.Inputs.Day10
open Utils

type CycleState = { cycle : int; value: int; endOfCycleValue : int }

module CycleState =
    let product c = c.cycle * c.value

let importantCycles = [|20; 60; 100; 140; 180; 220|]

let execute reg command startingCycle =
    match splitBy " " command with
    | [|"noop"|] -> [{ cycle = startingCycle; value = reg; endOfCycleValue = reg; }],reg
    | [|"addx"; num |] ->
        let endValue = (reg + (int num))
        [
            { cycle = startingCycle; value = reg; endOfCycleValue = reg; };
            { cycle = startingCycle + 1; value = reg; endOfCycleValue = endValue; }
        ], endValue
    | _ -> failwith "cant interpret"

let executeAll lines=
    let results,_,_ =
        lines
        |> Seq.fold (fun (currCycles : CycleState list, v : int, cycle : int) curr ->
            let newCycles,newV = execute v curr cycle
            let allCycles = List.concat [currCycles; newCycles]
            let newCycleNum = cycle + List.length newCycles
            allCycles,newV,newCycleNum
            ) ([],1,1)
    results

let get1Value cycles =
    let relevantCycles =
        cycles
        |> Seq.filter (fun state -> Seq.contains state.cycle importantCycles)
    // [for state in x do
    //      Console.WriteLine(state.cycle.ToString() + "," + state.value.ToString() + " " + (CycleState.product state).ToString())] |> ignore
    
    relevantCycles
    |> Seq.map CycleState.product
    |> Seq.fold (+) 0
    
    

let run = splitInputByNewLines >> executeAll >> get1Value

let print1 = printfn $"{run sample1} {run input1}"



let printCycle cycle =
    let position = (cycle.cycle - 1) % 40 
    if position = 0 then Console.WriteLine()
    
    if position >= cycle.value - 1 && position <= cycle.value + 1 then
        Console.Write("#")
    else Console.Write(" ")
    
    // Console.Write(cycle.value)
    // Console.Write(' ')

let printCRT cycles =
    cycles |> List.map printCycle |> ignore
    Console.WriteLine("\n\n\n")
    
let runAndPrint = splitInputByNewLines >> executeAll >> printCRT


let print2 = printfn $"{runAndPrint sample1} {runAndPrint input1}"