open System

let input = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map int

let rec GCD x y = 
        match (x, y) with
        | (x, y) when x=y -> x
        | (x, y) when x>y -> GCD (x-y) y
        | _ -> GCD (y-x) y

let result = GCD input.[0] input.[1]