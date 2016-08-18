namespace fsharphackerrank

open System

module Arrays =

    let arrayLength =  Console.ReadLine()
    let arrayValues = Console.ReadLine()
    
    arrayValues.Split [|' '|]
    |> Array.rev
    |> String.concat " "
    |> printfn "%s"


      
 




