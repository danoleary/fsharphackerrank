open System

let n = Console.ReadLine() |> int
[1..n] |> List.iter (printfn "Hello World")

