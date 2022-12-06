module Utils

open System
open System.Collections.Generic

let reverse (input:string) = input |> Seq.rev |> System.String.Concat
let joinInts (separator : string) (ints : seq<int>) =
    ints
    |> Seq.map (fun x -> x.ToString())
    |> String.concat separator