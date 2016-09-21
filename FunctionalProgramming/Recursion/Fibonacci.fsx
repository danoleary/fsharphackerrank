open System

let n = Console.ReadLine() |> int

let rec fib n = 
        match n with
        | 1 -> 0 
        | _ -> fib(n-1) + fib(n-2)

let result = fib n

printfn "%i" result