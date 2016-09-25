open System

let n = Console.ReadLine() |> int

let read _ = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map int |> (fun x -> x.[0], x.[1])

let list = Seq.initInfinite read |> Seq.take n

let distanceBetweenTwoPoints a b = 
        let xDiff = (fst a) - (fst b)
        let yDiff = (snd a) - (snd b)
        sqrt (float (xDiff * xDiff) + float (yDiff * yDiff))

let calculatePerimeter (list: seq<int * int>) = list |> Seq.pairwise 
                                                     |> Seq.map distanceBetweenTwoPoints
                                                     |> Seq.reduce +
                                                      

                                   

