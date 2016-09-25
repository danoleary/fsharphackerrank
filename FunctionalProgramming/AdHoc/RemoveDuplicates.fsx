open System

let input = Console.ReadLine()

let removeDuplicates (s: string) = s 

let result = removeDuplicates input |> Seq.distinct |> String.Concat

printfn "%s" result