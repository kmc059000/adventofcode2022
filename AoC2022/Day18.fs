module Day18

open System
open AoC2022.Inputs.Day18
open Utils

let parseLine line =
    let tokens = splitBy "," line |> Array.map int
    (tokens[0],tokens[1],tokens[2])



let parse = splitInputByNewLines >> Seq.map parseLine >> Set.ofSeq

let countSides (x,y,z) positions =
    [
        0,0,1;
        0,1,0;
        1,0,0;
        0,0,-1;
        0,-1,0;
        -1,0,0;        
    ]
    |> Seq.map (fun (dx,dy,dz) -> (x + dx, y + dy, z + dz))
    |> Seq.filter (fun x -> not (Set.contains x positions))
    |> Seq.length
    
let p1 input =
    let positions = parse input
    positions
    |> Seq.sumBy (fun x -> countSides x positions)
    
let print1 =
    Console.WriteLine(p1 sample1)
    Console.WriteLine(p1 sample2)
    Console.WriteLine(p1 input1)
    ()

let neighbors (x,y,z) =
    Seq.map (fun (dx,dy,dz) -> (x + dx, y + dy, z + dz)) [
        0,0,1;
        0,1,0;
        1,0,0;
        0,0,-1;
        0,-1,0;
        -1,0,0;        
    ]
    
let maybeAddToSet item set = Option.map (Set.add item) set
    
let findPathIfBounded maxDepth (x,y,z) positions =
    let rec dfs (x,y,z) depth discovered =
        if Option.isNone discovered || depth = maxDepth then
            None
        else
            let newDiscovered = maybeAddToSet (x,y,z) discovered |> Option.get
            neighbors (x,y,z)
            |> Seq.filter (fun p -> Set.contains p newDiscovered)
            |> Seq.fold (fun acc curr -> dfs curr (depth + 1) acc
                ) (Some newDiscovered)
    dfs 



let print2 =
    Console.WriteLine(p2 sample1)
    Console.WriteLine(p2 sample2)
    Console.WriteLine(p2 input1)
    ()
    