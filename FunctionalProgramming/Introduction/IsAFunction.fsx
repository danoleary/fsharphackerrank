open System
let read _ = Console.ReadLine() 

let t = Console.ReadLine() |> int
[1..t] |>
        let n = Console.ReadLine() |> int
        let inputs = Seq.init n read |>
                        Seq.map (fun x -> x.Split ' ')
        





