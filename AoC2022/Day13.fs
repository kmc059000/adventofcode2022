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
    

let compare (val1,val2) =
    let rec inner (val1,val2) : int option =
        match val1,val2 with
        | Integer l, Integer r ->
            if l < r then Some -1
            else if l > r then Some 1
            else None
        | List l, List r ->
            match l,r with
            | [], [] -> None
            | [], _ -> Some -1
            | _, [] -> Some 1
            | l :: ls, r :: rs ->
                match inner (l,r) with
                | None -> inner (List ls,List rs)
                | x -> x
                
        | Integer l, List r -> inner (List [Integer l], val2)
        | List l, Integer r -> inner (val1, List [Integer r])
        
    (inner (val1,val2)) |> Option.get

let isInOrder (val1,val2) = compare (val1,val2) < 0
    
    
let lift op a b =
    match a, b with
    | Some av, Some bv  -> Some(op av bv)
    | _, _ -> None
    
let getSum input =
    parseLines input
    |> Array.map isInOrder
    |> Array.mapi (fun i x -> if x then Some (i + 1) else None)
    |> Array.choose id
    |> Array.fold (+) 0 

let print1 =
    Console.WriteLine(getSum sample1)
    Console.WriteLine(getSum input1)
    ()
    
    
let sort input =
    input + "\n\n[[2]]\n[[6]]"
    |> parseLines
    |> Seq.map (fun (a,b) -> [a; b])
    |> Seq.collect id
    |> Seq.sortWith (fun a b -> compare (a,b))
    |> List.ofSeq
    
let getKey values =
    values
    |> Seq.fold (fun (sum,idx) curr ->
        match curr with
        | List [List [Integer 2]] -> (sum * idx,idx + 1)
        | List [List [Integer 6]] -> (sum * idx,idx + 1)
        | _ -> (sum,idx+1)
        ) (1,1)
    |> fst
    
let solve2 = (sort >> getKey) 
   
let print2 =
    Console.WriteLine(solve2 sample1)
    Console.WriteLine(solve2 input1)
    ()