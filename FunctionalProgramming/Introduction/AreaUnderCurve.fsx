open System

let readInputStringToIntArray = Console.ReadLine() |> (fun x -> x.Split ' ') |> Array.map (int)
let aValues = readInputStringToIntArray
let bValues = readInputStringToIntArray
let rAndlValues = readInputStringToIntArray

let abCombined = Array.zip aValues bValues

let term (abx: int * int * int) = 
                let (a, b, x) = abx
                let a = float a
                let b = float b
                let x = float x
                a * (x ** b) 

let polynomial array x = array |> Array.map (fun ab -> fst ab, snd ab, x) |> Array.map term |> Array.sum

let max





