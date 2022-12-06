module Day02

open System
open AoC2022.Inputs.Day02
type Policy = {
    MinOccur: int
    MaxOccur: int
    Letter: char
}

type Password = Policy * string

let parsePassword (str: string) =
    let tokens = str.Split([|"-"; " "; ":"|], StringSplitOptions.RemoveEmptyEntries)
    {
        MinOccur = tokens.[0] |> int
        MaxOccur = tokens.[1] |> int
        Letter = tokens.[2].[0]
    }, tokens.[3]


let parsedpw = parsePassword "2-9 c: ccccccccc"

let countCharacter char (str: string) = 
    let rec loop i count =
        if i < str.Length then 
            if str.[i] = char then loop (i+1) (count + 1)
            else loop (i+1) count
        else count
    loop 0 0

let isValidPasswordOld (policy, pw) =
    let charCount = countCharacter policy.Letter pw
    charCount >= policy.MinOccur && charCount <= policy.MaxOccur

let readInput (input: string) = 
    input.Split('\r', '\n')
    |> Seq.ofArray
    |> Seq.map (fun w -> w.Trim())
    |> Seq.map parsePassword

let countValidPasswords pwValidator input =
    input
    |> readInput
    |> Seq.filter pwValidator
    |> Seq.length

let countOldPolicy = countValidPasswords isValidPasswordOld


let a1sample = countOldPolicy sample
let a1 = countOldPolicy mainInput




let isValidPasswordNew (policy, pw : string) =
    let m1 = pw.[policy.MinOccur - 1] = policy.Letter
    let m2 = pw.[policy.MaxOccur - 1] = policy.Letter
    m1 <> m2

let countNewPolicy = countValidPasswords isValidPasswordNew

let a2sample = countNewPolicy sample
let a2 =countNewPolicy mainInput

let solveDay0201 = printfn $"{a1sample} {a1}"
let solveDay0202 = printfn $"{a2sample} {a2}"