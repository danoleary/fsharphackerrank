open System

let read _ = Console.ReadLine() 

let isNotNull x = 
        match x with
        | null -> false
        | _ -> true

let list = Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.map int

list |> Seq.rev |> Seq.iter (printfn "%i")
