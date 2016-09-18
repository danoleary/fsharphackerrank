namespace fsharphackerrank

open System

module Recursion =

    let input = int (Console.ReadLine())
    let factorial n = [1..n] |> List.reduce (*)
    let output = factorial input
    printfn "%i" output





      
 




