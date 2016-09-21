open System

let input = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map int

let rec gcd x y = 
        match y with
        | 0 -> x
        | _ -> gcd y (x % y)

let a = input.[0]

let b = input.[1]

let result = gcd a b

printfn "%i" result