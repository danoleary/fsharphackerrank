namespace fsharphackerrank

open System

module IntroToConditionalStatements =

    let printValue x = 
        match x with
        | x when (x % 2) = 0 ->
            match x with
            | x when x >= 2 && x <= 5 -> printfn "Not Weird"
            | x when  x >= 6 && x <= 20 -> printfn "Weird"
            | _ -> printfn "Not Weird"
        | _  -> printfn "Weird"

    let input =  Console.ReadLine()
    
    printValue (int input)
      
 




