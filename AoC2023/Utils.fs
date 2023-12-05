module Utils

open System
open System.Collections.Generic

let reverse (input:string) = input |> Seq.rev |> System.String.Concat
let joinInts (separator : string) (ints : seq<int>) =
    ints
    |> Seq.map (fun x -> x.ToString())
    |> String.concat separator
    
let splitBy (separator : string) (str: string) = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)

let splitBy2 (separator : string) (str: string) =
    let tokens = splitBy separator str
    tokens[0], tokens[1]


let splitBySpaces = splitBy " "
let splitByComma = splitBy ","

let splitIntsBySpaces = splitBySpaces >> Seq.map int

let splitInputByNewLines (str : string) = str.Split("\n", StringSplitOptions.RemoveEmptyEntries)

let splitInputByDoubleNewLines (str : string) = str.Split("\n\n", StringSplitOptions.RemoveEmptyEntries)

let parseInt (str : string) = Int32.Parse(str)

let splitByAll (separators : string) (str: string) = str.Split(separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
    
let chars (str : string) = str.ToCharArray() |> Array.map string

let replace (find: string) (replacement: string) (string : string) = string.Replace(find, replacement)

let toString x = x.ToString()

let indexOf (find: string) (str : string) = str.IndexOf(find)
let lastIndexOf (find: string) (str : string) = str.LastIndexOf(find)

let tapValue value =
    Console.WriteLine(value.ToString())
    value
    
let tapValues<'a> : 'a seq -> 'a seq = Seq.map tapValue
    
let tapValue2 v1 value =
    Console.WriteLine(v1.ToString() + " " + value.ToString())
    value
    
    
let flip f x y = f y x

let isPositive x = x >= 0

let joinMaps (p:Map<'a,'b>) (q:Map<'a,'b>) = 
    Map(Seq.concat [ (Map.toSeq p) ; (Map.toSeq q) ])
    
let toTuple xFn yFn value = (xFn value, yFn value)


let parseGrid parseLine combineLines (input : string) =
    input
    |> splitInputByNewLines
    |> Seq.mapi parseLine
    |> combineLines
    
let fst3 (x,_,_) = x

let default0 = Option.defaultValue 0
let default1 = Option.defaultValue 1

let atLeast1 num = Math.Max(1, num)

let mergeMaps map1 map2 =
    map1
    |> Map.toList
    |> List.fold (fun acc (key, value) ->
        Map.add key value acc
    ) map2
    
let mergeManyMaps maps =
    maps
    |> Seq.fold (fun acc map -> mergeMaps acc map) Map.empty