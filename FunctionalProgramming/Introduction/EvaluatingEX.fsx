open System

let read _ = Console.ReadLine() 

let isNotNull x = 
        match x with
        | null -> false
        | _ -> true

let n = read ()
let list = Seq.initInfinite read |> Seq.takeWhile isNotNull |> Seq.map float

let multiply x y = x * y
let factorial x = [1..x] |> List.reduce (multiply)
let term x n = (x ** float n) / float (factorial n)

let firstTenTerms x = [1..10] 
                                |> List.map (fun i -> term x i) 
                                |> List.sum
                                |> (fun y -> System.Math.Round(y, 4))
                                |> (fun y -> y + float 1)
                         
firstTenTerms 20.0000

list |> Seq.iter (fun x -> printfn "%f" (firstTenTerms x))
