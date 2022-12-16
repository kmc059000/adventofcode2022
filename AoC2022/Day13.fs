module Day13

open System
open System.Text.RegularExpressions
open AoC2022.Inputs.Day13
open Utils

type Value =
    | Integer of int
    | List of Value list


let commasNotInBraces = Regex(",(?![^[\]]*\])")

let splitByCommasNotWrappedInBraces (str : string) =
    let mutable braceCount = 0
    let mutable tokenIdx = 0
    let mutable tokens = []
    let mutable idx = 0
    for c in str do
        if c = '[' then
            braceCount <- braceCount + 1
        else if c = ']' then
            braceCount <- braceCount - 1
        else if c = ',' && braceCount = 0 then
            tokens <- str.Substring(tokenIdx, idx - tokenIdx).Trim(',') :: tokens
            tokenIdx <- idx
        
        idx <- idx + 1
        
    if tokenIdx <> idx then
        tokens <- str.Substring(tokenIdx, idx - tokenIdx).Trim(',') :: tokens
        
    tokens |> List.rev

let rec parse (str: string) : Value =
    if str.StartsWith("[") && str.EndsWith("]") then
        let str = str.Substring(1, str.Length - 2)
        List (splitByCommasNotWrappedInBraces str |> Seq.ofList |> Seq.map parse |> List.ofSeq)      
    else if str = "" then List List.empty
    else (Integer (int str))
    
let parseLines str =
    str
    |> splitInputByDoubleNewLines
    |> Array.map (splitInputByNewLines >> Array.map parse)
    |> Array.map (fun arr -> arr[0],arr[1])
    

let isInOrder (val1,val2) =
    
    let rec inner (val1,val2) : bool option =
        match val1,val2 with
        | Integer l, Integer r ->
            if l < r then Some true
            else if l > r then Some false
            else None
        | List l, List r ->
            match l,r with
            | [], [] -> None
            | [], _ -> Some true
            | _, [] -> Some false
            | l :: ls, r :: rs ->
                match inner (l,r) with
                | None -> inner (List ls,List rs)
                | x -> x
                
        | Integer l, List r -> inner (List [Integer l], val2)
        | List l, Integer r -> inner (val1, List [Integer r])
        
    (inner (val1,val2)) |> Option.defaultValue false
    
    
    
let lift op a b =
    match a, b with
    | Some av, Some bv  -> Some(op av bv)
    | _, _ -> None
    
let getSum input =
    parseLines input
    |> Array.mapi (fun i x -> if isInOrder x then Some (i + 1) else None)
    |> Array.choose id
    |> Array.fold (+) 0 

let print1 =
    Console.WriteLine(getSum sample1)
    Console.WriteLine(getSum input1)
    ()
let print2 = ()