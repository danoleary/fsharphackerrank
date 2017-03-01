open System

[<EntryPoint>]
let main argv = 

    let numInputs = Console.ReadLine() |> int
    let read _ = Console.ReadLine()
    let inputs = Seq.initInfinite read |> Seq.take numInputs |> List.ofSeq

    let getRotations input =
        let length = String.length input
        let rec rotateRec word result i =
            if i = length then
                result
            else
                let rotate x =
                    match x with
                    | hd::tail -> tail @ [hd] |> Array.ofList |> System.String
                    | _ -> ""
                let newWord = rotate (word |> List.ofSeq)
                
                let newResult = sprintf "%s %s" result newWord

                rotateRec newWord newResult (i+1)
        Console.WriteLine((rotateRec input "" 0).Trim()) |> ignore

    inputs |> List.iter getRotations

    0