namespace fsharphackerrank

open System

module BinaryNumbers =

    let decimalN = int (Console.ReadLine())

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

    let maxConsecutiveOnesFromEnd = [(binaryLength - 1)..0] 
                                    |> List.map binaryN.Substring 
                                    |> List.filter (fun x -> (x.Contains "0") = false) 
                                    |> List.maxBy String.length 
                                    |> String.length

    let maxInt x y =
            match x with
            | x when x > y -> x
            | _ -> y

    let max = maxInt maxConsecutiveOnesFromStart maxConsecutiveOnesFromEnd

    printfn "%i" max
 




