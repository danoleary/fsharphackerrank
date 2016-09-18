open System

let read _ = Console.ReadLine() 

let isNotNull x = 
        match x with
        | null -> false;
        | _ -> true

let multiplier = read () |> int
let list = Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.map int

let printElement element = 
    [1..multiplier] |> Seq.iter (fun _ -> printfn "%i" element)

list |> Seq.iter printElement





