open System

let read _ = Console.ReadLine() 

let isNotNull x = 
        match x with
        | null -> false
        | _ -> true

let list = Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.map int

list |> Seq.mapi (fun i x -> i % 2  = 0, x)
     |> Seq.filter fst
     |> Seq.map snd
     |> Seq.iter (printfn "%i")
