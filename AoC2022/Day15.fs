module Day15

open System
open System.Text.RegularExpressions
open AoC2022.Inputs.Day15
open Utils

let parseLine (str : string) =
    let tokens = Regex("-?\d+").Matches(str) |> Seq.map (fun x -> int x.Value) |> Array.ofSeq
    (tokens[0],tokens[1]),(tokens[2],tokens[3])

let parse = splitInputByNewLines >> Array.map parseLine

let rangForRow excludeBeacon row (line : (int*int)*(int*int)) =
    let (sensorX,sensorY),(beaconX,beaconY) = line
    let dist = Math.Abs(sensorX - beaconX) + Math.Abs(sensorY - beaconY) 
    let distFromRow = Math.Abs(row - sensorY)
    let minX = sensorX - dist + distFromRow
    let maxX = sensorX + dist - distFromRow
    
    let excludeBeaconMinX = if excludeBeacon && beaconY = row && beaconX = minX then minX + 1 else minX
    let excludeBeaconMaxX = if excludeBeacon && beaconY = row && beaconX = maxX then maxX - 1 else maxX
    
    (excludeBeaconMinX,excludeBeaconMaxX)

let coveredPositionsForRow row (line : (int*int)*(int*int)) =
    let min,max = rangForRow true row line    
    seq { for x in min..max do x }
    

let linesAffectingRow row = Array.map (coveredPositionsForRow row) >> Seq.collect id >> Seq.distinct >> Seq.length

let p1 row input = (parse >> linesAffectingRow row) input
let print1 =
    // let s = p1 10 sample1
    // Console.WriteLine(s)
    //
    // let s = p1 2000000 input1
    // Console.WriteLine(s)
    ()


let getSurroundingCircle (line : (int*int)*(int*int)) =
    let (sensorX,sensorY),(beaconX,beaconY) = line
    let dist = Math.Abs(sensorX - beaconX) + Math.Abs(sensorY - beaconY) + 1
    
    let x = seq {
                for x in 0..(dist) do
                    seq {
                        (sensorX - x, sensorY - (dist - x))
                        (sensorX - x, sensorY + (dist - x))
                        (sensorX + x, sensorY - (dist - x))                                                
                        (sensorX + x, sensorY + (dist - x))
                    } |> Seq.distinct 
            } |> Seq.collect id
    
    
    let y = x |> Seq.toArray
    x
    
    
let pointNotInCircles signals (x,y) =
    let xRangesForCircles =
        signals
        |> Seq.map (rangForRow false y)
        |> Seq.filter (fun (minX,maxX) -> minX < maxX )
        |> List.ofSeq
    
    let rec allRangesMatch fn ranges =
        match ranges with
        | [] -> true
        | x :: xs ->
            if fn x then
                allRangesMatch fn xs
            else false
    
    let b = allRangesMatch (fun (minX,maxX) -> x < minX || x > maxX ) xRangesForCircles        
    
    if b then
        Console.WriteLine(x.ToString() + "," + y.ToString())
    b
    
    
let p2 range input =
    let signals = parse input
    let candidates = (Seq.ofArray >> Seq.collect getSurroundingCircle >> Seq.distinct >> Seq.filter (fun (x,y) -> x > 0 && x < range && y > 0 && y < range )) signals
    
    Console.WriteLine("Candidates" + (candidates |> Seq.length).ToString())
    
    candidates |> Seq.filter (pointNotInCircles signals) |> Seq.head


let constrain range value = Math.Min(range, Math.Max(0, value))

let collapseRanges range ranges =
    ranges
    |> Seq.fold (fun acc (currMin : int, currMax : int) ->
        match acc with
        | [] -> [(currMin, currMax)]
        | (lastMin, lastMax) :: xs ->
            if currMin <= lastMax then
                (lastMin, Math.Max(currMax, lastMax)) :: xs
            else
                (currMin, currMax) :: (lastMin, lastMax) :: xs
        ) []
    |> Seq.map (fun (min,max) -> (constrain range min, constrain range max))

let p2Better range input =
    let signals = parse input
    for row in 0..range do
        let ranges = signals |> Seq.map (rangForRow false row) |> Seq.filter (fun (min,max) -> min <= max) |> Seq.sortBy fst
        let collapsedRanges = collapseRanges range ranges |> Seq.toArray
        
        Console.WriteLine(String.Join(" | ", collapsedRanges) + "\t\t-\t" + String.Join(" | ", ranges))         
    ()
        

let print2 =
    let s = p2 20 sample1
    Console.WriteLine(s)
    
    let s = p2 4000000 input1
    Console.WriteLine(s)
    ()
    