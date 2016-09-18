namespace fsharphackerrank

open System

module LetsReview =

    let getOddsOrEvens list indices = List.foldBack (fun x (l,r) -> x::r, l) list ([],[]) 
                                        |> indices
                                        |> List.toArray 
                                        |> String 

    let getOdds list = getOddsOrEvens (List.ofSeq list) fst

    let getEvens list = getOddsOrEvens (List.ofSeq list) snd

    let printOddsAndEvens input = printfn "%s %s" (getOdds input) (getEvens input)

    let numInputs = int (Console.ReadLine())

    [1..numInputs] |> List.map (fun n -> printOddsAndEvens (Console.ReadLine()))


      
 




