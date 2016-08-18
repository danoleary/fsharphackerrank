namespace fsharphackerrank

open System

module IntroToConditionalStatements =

    let isEven x = (x % 2) = 0
    let isOdd x = isEven x = false

    let printValue x= 
        match x with
        | x when isOdd x -> printfn "Weird"
        | x when isEven x ->
            match x with
            | x when x >= 2 && x <= 5 -> printfn "Not Weird"
            | x when  x >= 6 && x <= 20 -> printfn "Weird"
            | _ -> printfn "Not Weird"

    let input =  Console.ReadLine()
    
    printValue (int input)
      
 




