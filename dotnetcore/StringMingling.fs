open System

[<EntryPoint>]
let main argv = 
    let p = Console.ReadLine() |> List.ofSeq |> List.toArray
    let q = Console.ReadLine() |> List.ofSeq |> List.toArray

    let mingle (p: char array) (q: char array) =
        let length = Array.length p
        let result = Array.zeroCreate (length * 2)
        let rec mingleRec arr i =
            if i = length then
                arr
            else
                Array.set arr (i*2) p.[i] |> ignore
                Array.set arr ((i*2)+1) q.[i] |> ignore
                mingleRec arr (i+1)
        mingleRec result 0 

    let result = mingle p q

    Console.WriteLine(result |> System.String)

    0