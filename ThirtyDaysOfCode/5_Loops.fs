namespace fsharphackerrank

open System

module Loops =

    let n = int (Console.ReadLine())

    [1..10] |> List.iter (fun i -> printfn "%i x %i = %i" n i (i*n)) 

      
 




