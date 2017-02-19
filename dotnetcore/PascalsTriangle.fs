open System

[<EntryPoint>]
let main argv = 
    let k = Console.ReadLine() |> int

    let factorial n =
        [1..n] |> List.reduce (fun s i -> s * i) 

    let value n r = 
        if r = 0 || r = n then
            1
        else
            (factorial n) / ((factorial r) * (factorial (n - r)))

    let printLine n = 
        let str = [0..n] |> List.fold (fun s i -> sprintf "%s %i" s (value n i)) ""
        printfn "%s" (str.Trim())

    let printPascalsTriangle k =
        [0..(k-1)] |> List.iter printLine |> ignore

    printPascalsTriangle k

    0
