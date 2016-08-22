open System

let decimalN = 439

let rec decimalToBinary n acc = 
    match n with
    | 0 -> acc
    | _ -> decimalToBinary (n / 2) (string (n % 2) + acc)

let binaryN = decimalToBinary decimalN ""

let binaryLength = String.length binaryN

let maxConsecutiveOnesFromStart = [0..(binaryLength - 1)] 
                                |> List.map binaryN.Substring 
                                |> List.filter (fun x -> (x.Contains "0") = false) 
                                |> List.maxBy String.length 
                                |> String.length

let maxConsecutiveOnes = [(binaryLength - 1)..0] 
                                |> List.map binaryN.Substring 
                                |> List.filter (fun x -> (x.Contains "0") = false) 
                                |> List.maxBy String.length 
                                |> String.length 

let rec comb n l =
  match (n,l) with
  | (0,_) -> [[]]
  | (_,[]) -> []
  | (n,x::xs) ->
      let useX = List.map (fun l -> x::l) (comb (n-1) xs)
      let noX = comb n xs
      useX @ noX

let combinations = comb 2 [0..(binaryLength - 1)] 

let maxConsecutiveOnes = combinations
                        |> List.map (fun x -> binaryN.Substring (x.[0] x.[1]) 
                        |> List.filter (fun x -> (x.Contains "0") = false) 
                        |> List.maxBy String.length 
                        |> String.length                             

let maxInt x y =
        match x with
        | x when x > y -> x
        | _ -> y

let max = maxInt maxConsecutiveOnesFromStart maxConsecutiveOnesFromEnd

printfn "%i" max
 




