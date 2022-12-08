module Utils

open System
open System.Collections.Generic

let reverse (input:string) = input |> Seq.rev |> System.String.Concat
let joinInts (separator : string) (ints : seq<int>) =
    ints
    |> Seq.map (fun x -> x.ToString())
    |> String.concat separator
    
let splitBy (separator : string) (str: string) = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)

let splitInputByNewLines (str : string) = str.Split("\n", StringSplitOptions.RemoveEmptyEntries)

let splitInputByDoubleNewLines (str : string) = str.Split("\n\n", StringSplitOptions.RemoveEmptyEntries)

let parseInt (str : string) = Int32.Parse(str)

let splitByAll (separators : string) (str: string) = str.Split(separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
    
let chars (str : string) = str.ToCharArray() |> Array.map string