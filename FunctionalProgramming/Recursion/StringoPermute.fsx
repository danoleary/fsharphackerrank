open System

let n = Console.ReadLine() |> int 

let inputs = [0..n-1] |> List.map (fun x -> Console.ReadLine()) |> List.map List.ofSeq

let rec swap chars (i: int) (acc: char array) =
    match chars with
    | [] -> acc
    | [hd] -> acc
    | hd::(hd2::tl) ->
        acc.[i] <- hd2
        acc.[i+1] <- hd
        swap tl (i+2) acc

let result = inputs
            |> List.map (fun x -> 
                           let array = Array.create (List.length x) '-'
                           swap x 0 array) 

result |> List.map String |> List.iter (fun x -> printfn "%s" x)

