module Day07

open AoC2022.Inputs.Day07
open Utils

type Line =
    | Cd of string
    | Ls
    | FileMetadata of int
    | DirMetadata of string
    
let parseLine line =
    match (splitBy " " line) with
    | [| "$"; "cd"; dir |] -> Cd dir
    | [| "$"; "ls" |] -> Ls
    | [| "dir"; dir |] -> DirMetadata dir
    | [| size; _ |] -> FileMetadata (int size)
    | _ -> failwith "cant parse"

let parseInput = splitInputByNewLines >> Seq.map parseLine

let traverseAndCollect lines =
    lines
    |> Seq.fold (fun acc curr ->
        let sizes,path = acc
        match curr with
        | Line.Ls -> acc
        | DirMetadata _ -> acc
        
        | Cd "/" -> acc
        | Cd ".." -> sizes, List.tail path
        | Cd dir ->
            let newPath = (List.head path) + "/" + dir 
            sizes, newPath :: path
        
        | FileMetadata size ->
            let addSize = Option.defaultValue 0 >> Some >> Option.map ((+) size)
            let newSizes = Seq.fold (fun sizes dir -> Map.change dir addSize sizes) sizes path
            newSizes, path
        ) (Map.empty<string, int>,["/"])
    |> fst
    
let sumDirsUnderCap (maxSize : int) fs =
    fs
    |> Map.values
    |> Seq.filter ((>) maxSize)
    |> Seq.sum

let solve1 = parseInput >> traverseAndCollect >> sumDirsUnderCap 100000
let print1 = printfn $"{solve1 sample1} {solve1 input1}"

let findSmallestOverCap (maxSize : int) (fs : Map<string, int>) =
    let usedSpace = Map.find "/" fs
    let minDirSize = maxSize - (70000000 - usedSpace)
    fs
    |> Map.values
    |> Seq.filter ((<) minDirSize)
    |> Seq.min
    
let solve2 = parseInput >> traverseAndCollect >> findSmallestOverCap 30000000
let print2 = printfn $"{solve2 sample1} {solve2 input1}"