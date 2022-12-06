module Utils

open System
open System.Collections.Generic

let reverse (input:string) = input |> Seq.rev |> System.String.Concat
