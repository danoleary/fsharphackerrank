open System

let read _ = Console.ReadLine() 

let isNotNull x = 
        match x with
        | null -> false
        | _ -> true

let delimiter = read () |> int
let list = Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.map int

let isLessThanDelimiter x = x < delimiter

list |> Seq.filter isLessThanDelimiter |> Seq.iter (printfn "%i")





