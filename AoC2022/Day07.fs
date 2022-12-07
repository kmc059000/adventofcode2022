module Day07

open System
open System.Collections.Generic
open AoC2022.Inputs.Day07
open Utils

type FsNode =
    | Directory of Dir
    | File of File

and Dir = { name : string; nodes : FsNode list }
and File = { name : string; size : int }
        

module Dir =
    let root = { name = "/"; nodes = List.empty }
    let empty name = { name = name; nodes = List.empty }
    
    let addNode node dir =
        { dir with nodes = (node :: dir.nodes) }
        
    let addNodeToPath node path =
        path |> 
        (List.head path |> addNode node) :: List.tail path
        
    let getRoot = List.last

module Parsing =
    type Line =
        | Cd of string
        | Ls
        | FileMetadata of string*int
        | DirMetadata of string
        
    let parseLines strings =
        let parseLine (line: string) =
            match (splitBy " " line) with
            | [| "$"; "cd"; dir |] -> Cd dir
            | [| "$"; "ls" |] -> Ls
            | [| "dir"; dir |] -> DirMetadata dir
            | [| size; name |] -> FileMetadata (name, int size)
            | _ -> failwith "cant parse"
        
        strings
        |> Seq.map parseLine
        
    let parseInput = splitInputByNewLines >> parseLines

let buildFs lines =
    lines
    |> Seq.fold (fun path curr ->
        match curr with
        | Parsing.Line.Cd "/" -> path
        | Parsing.Line.Cd ".." -> List.tail path
        | Parsing.Line.Cd dir ->
            let currDir = List.head path
            let newDir = currDir.nodes
                      |> Seq.find (fun node ->
                                     match node with
                                     | Directory childDir when childDir.name = dir -> true
                                     | _ -> false)
                      
            match newDir with
            | Directory d -> d :: path
            | _ -> failwith "cant cd into non-directory"
        | Parsing.Line.Ls -> path
        | Parsing.Line.FileMetadata (name,size) ->
            let file = { name = name; size = size }
            Dir.addNodeToPath (File file) path
            
        | Parsing.Line.DirMetadata name ->
            let child = Dir.empty name
            Dir.addNodeToPath (Directory child) path        
        ) [Dir.root]

let rec getSize1 maxSize fs =
    let rec inner accum fs =
        match fs with
        | Directory dir ->
            let childrenSizes = dir.nodes |> Seq.fold inner []
            let totalSize = childrenSizes |> Seq.sumBy fst
            if totalSize > maxSize
            then ((totalSize, Some dir) :: accum)
            else accum
        | File f -> [f.size,None]
    
    let smallDirs = inner [] fs
    smallDirs |> Seq.map fst |> Seq.sum
    
let calculateSize1 = Parsing.parseInput >> buildFs >> Dir.getRoot >> Directory >> getSize1 100000

let sampleResult = calculateSize1 sample1

let solve1 = printfn $"{sampleResult}"
let solve2 = printfn $"{sample1}"


// TOMORROW
// it isnt that hard. Build a map where the key is each path for a dir.
// traverse the lines, keep track of the current path, and when a file is encountered, add its size to every parent.