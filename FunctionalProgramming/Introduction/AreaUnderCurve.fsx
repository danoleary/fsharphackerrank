open System

// let readInputStringToIntArray = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map (int)
// let abCombined = Array.zip readInputStringToIntArray readInputStringToIntArray
// let rAndlValues = readInputStringToIntArray

let abCombined = [(1, 6); (2, 7); (3, 8); (4, 9); (5, 10)] |> List.toArray
let rAndlValues = [1; 4]

//increase index by 1 and divide by new index
let term (abx: float * float * float) = 
                let (a, b, x) = abx
                (a / b) * (x ** (b + float 1)) 

let r = float rAndlValues.[0]
let l = float rAndlValues.[1]
let intervals = [r .. 0.0001 .. l]

let sumForValue (ab: int * int) = intervals 
                                |> List.map (fun y -> float (fst ab), float (snd ab), y)
                                 |> List.map term
                                 |> List.sum


let total = abCombined |> Array.map sumForValue 

// get value for each interval between r and l






