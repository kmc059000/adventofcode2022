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


        

let print2 =
    
    ()
    