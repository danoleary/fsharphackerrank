open System

let read _ = Console.ReadLine() 

let numPoints = read () |> int

let points =
        [0..numPoints-1] 
        |> List.map 
                (fun i -> 
                    let coords =  (read ()).Split(' ')
                    (float coords.[0], float coords.[1])
              )

//let points = [(4,10); (9,7); (11,2); (2,2); (4, 10)] // 45.5
//let points = [(1043,770); (551,990); (681,463)] // 115342.0

let adjacentPointsDistance (p1, p2) =
        let x1 = fst p1
        let y1 = snd p1
        let x2 = fst p2
        let y2 = snd p2
        (x1 * y2) - (y1 * x2)

let rec area points firstPoint acc =
        match points with
        | [] ->  acc
        | [hd] -> (acc + (adjacentPointsDistance (hd, firstPoint))) / 2.0
        | hd::[tl] -> 
                let newAcc = acc + (adjacentPointsDistance (hd, tl))
                area [tl] firstPoint newAcc
        | hd::(hd2::tl) -> 
                let newAcc = acc + (adjacentPointsDistance (hd, hd2))
                area (hd2::tl) firstPoint newAcc

let firstp = points.[0]
let result = area points firstp 0.0
printfn "%f" result