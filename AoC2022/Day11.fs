module Day11

open System
open AoC2022.Inputs.Day11
open Utils


type Monkey = {
    idx : int;
    items: int64 list;
    operation: int64 -> int64;
    testFn: int64 -> int
    timesInspected: int;
}

module Parsing =
    let parseOperation (line : string) =
        let stripped = line.Replace("  Operation:", "") |> splitByAll " "
        match stripped with
        | [|"new"; "="; "old"; "*"; "old" |] -> (fun x -> x  * x)
        | [|"new"; "="; "old"; "*"; x |] -> (*) (int64 x)
        | [|"new"; "="; "old"; "+"; x |] -> (+) (int64 x)
        | _ -> failwith "unhandled operation"
        
    let parseTest (line1 : string) (line2 : string) (line3 : string) : (int64 -> int) =
        let testFn : (int64 -> bool) =
            match splitByAll " " (line1.Replace("  Test:", "")) with
            | [| "divisible"; "by"; divisor |] -> (fun num -> num % (int64 divisor) = 0 )
            | _ -> failwith "cant parse test"
            
        let trueCase = line2.Replace("    If true: throw to monkey ", "") |> int
        let falseCase = line3.Replace("    If false: throw to monkey ", "") |> int
        
        (fun (num : int64) -> if testFn num then trueCase else falseCase)
        
        

    let parseMonkey (lines : string[]) =
        {
            idx = int <| lines[0].Replace("Monkey ", "").Replace(":", "");
            items = lines[1].Replace("Starting items:", "").Replace(" ", "").Split(",") |> Seq.map int64 |> List.ofSeq;
            operation = parseOperation lines[2];
            testFn = parseTest lines[3] lines[4] lines[5]
            timesInspected = 0;
        }
        
    let parseAllMonkeys = splitInputByDoubleNewLines >> Array.map (splitInputByNewLines >> parseMonkey)
    
    let toMap monkeys = monkeys |> Seq.map (fun m -> m.idx,m) |> Map.ofSeq
    
    
module Processing =
    let removeItem =
        Option.map (fun m -> { m with items = List.tail m.items })
        
    let addItem item =
        Option.map (fun m -> { m with items = List.concat [m.items; [item]] })
        
    let incProcessed =
        Option.map (fun m -> { m with timesInspected = m.timesInspected + 1 })
    
    let processItem worry monkey monkeys (item : int64) =
        let newWorryLevel = if worry then monkey.operation item / (int64 3) else monkey.operation item
        let newMonkey = monkey.testFn newWorryLevel
        monkeys 
        |> Map.change monkey.idx (removeItem)
        |> Map.change monkey.idx incProcessed
        |> Map.change newMonkey (addItem newWorryLevel) 
    
    let processMonkey worry monkeys monkey =
        monkey.items
        |> Seq.fold (processItem worry monkey) monkeys
        
    let processMonkeys worry (monkeys : Map<int,Monkey>) =
        seq { 0..(Seq.length monkeys - 1) }
        |> Seq.fold (fun monkeys idx ->
            monkeys
            |> Map.find idx
            |> processMonkey worry monkeys
            ) monkeys
    
    
let runRounds worry n str =
    let start = str |> (Parsing.parseAllMonkeys >> Parsing.toMap)
    seq { 1..n }
    |> Seq.fold (fun acc curr -> Processing.processMonkeys worry acc) start

let printItems monkeys =
    for idx,monkey in Map.toList monkeys do
        let items = String.Join(", ", monkey.items)
        Console.WriteLine($"{idx}\t{items}")
        
        
    Console.WriteLine("")
    Console.WriteLine("")
    monkeys
    
let score (monkeys : Map<int,Monkey>) =
    let scores =
        monkeys
        |> Map.values
        |> Seq.map (fun monkey -> monkey.timesInspected)
        
    scores
    |> Seq.mapi (fun i x -> Console.WriteLine(i.ToString() + " - " + x.ToString()))
    |> List.ofSeq
    |> ignore
    
    scores
    |> Seq.sortDescending
    |> Seq.take 2
    |> Seq.fold (*) 1
    
let printScore (score : int) = Console.WriteLine(score)
    
let print1 =
    sample1 |> runRounds true 1 |> printItems |> (score >> printScore) |> ignore
    
    sample1 |> runRounds true 20 |> printItems |> (score >> printScore) |> ignore
    
    
    input1 |> runRounds true 20 |> printItems |> (score >> printScore) |> ignore
    
    
let print2 =
    Console.WriteLine("**************** #2")
    sample1 |> runRounds false 1000 |> printItems |> (score >> printScore) |> ignore
    
    //sample1 |> runRounds false 10000 |> printItems |> (score >> printScore) |> ignore