namespace fsharphackerrank

open System

module DictionariesAndMaps =

    let read _ = Console.ReadLine()

    let numInputs = int (Console.ReadLine())

    let phoneBook = [1..numInputs] 
                    |> Seq.map (fun f -> Console.ReadLine())
                    |> Seq.map (fun f -> f.Split [|' '|])
                    |> Seq.map (fun f -> f.[0], f.[1]) 
                    |> Map.ofSeq

    let isNotNull x = 
        match x with
        | null -> false;
        | _ -> true

    let mapHasKey map key = map |> Map.exists (fun k _ -> (k = key))

    let printDetails name = 
        match (mapHasKey phoneBook name) with 
        | true -> printfn "%s=%s" name phoneBook.[name]
        | _ -> printfn "Not found"
        
    Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.toArray |> Array.iter printDetails





      
 




