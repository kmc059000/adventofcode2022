module Day15

open System
open System.Text.RegularExpressions
open AoC2022.Inputs.Day15
open Utils

let parseLine (str : string) =
    let tokens = Regex("-?\d+").Matches(str) |> Seq.map (fun x -> int x.Value) |> Array.ofSeq
    (tokens[0],tokens[1]),(tokens[2],tokens[3])

let parse = splitInputByNewLines >> Array.map parseLine

let coveredPositionsForRow row (line : (int*int)*(int*int)) =
    let (sensorX,sensorY),(beaconX,beaconY) = line
    let dist = Math.Abs(sensorX - beaconX) + Math.Abs(sensorY - beaconY) 
    let distFromRow = Math.Abs(row - sensorY)
    let minX = sensorX - dist + distFromRow
    let maxX = sensorX + dist - distFromRow
    
    let excludeBeaconMinX = if beaconY = row && beaconX = minX then minX + 1 else minX
    let excludeBeaconMaxX = if beaconY = row && beaconX = maxX then maxX - 1 else maxX
    
    seq { for x in excludeBeaconMinX..excludeBeaconMaxX do x }
    

let linesAffectingRow row = Array.map (coveredPositionsForRow row) >> Seq.collect id >> Seq.distinct >> Seq.length

let p1 row input = (parse >> linesAffectingRow row) input
let print1 =
    let s = p1 10 sample1
    Console.WriteLine(s)
    
    let s = p1 2000000 input1
    Console.WriteLine(s)
    ()

let print2 = ()