open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int

    let read _ = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map int |> (fun x -> x.[0], x.[1])

    let list = Seq.initInfinite read |> Seq.take n |> List.ofSeq

    let distanceBetweenTwoPoints a b = 
        let xDiff = (fst a) - (fst b)
        let yDiff = (snd a) - (snd b)
        sqrt (float (xDiff * xDiff) + float (yDiff * yDiff))

    let total testCases = 
        let numCases = List.length testCases
        [0..(numCases - 1)] 
        |> List.map (fun x ->
                        if x = numCases - 1 then
                            distanceBetweenTwoPoints testCases.[x] testCases.[0]
                        else
                            distanceBetweenTwoPoints testCases.[x] testCases.[x + 1])
        |> List.sum

    let result = total list
    Console.WriteLine(result)
    0
