open System

[<EntryPoint>]
let main argv = 

    // let someTestCases = [
    //     [(1, 1); (2, 2); (3, 3)]; // YES
    //     [(1, 2); (2, 4); (3, 6); (4, 8)]; // YES
    //     [(1, 2); (1, 3)] // NO
    // ]

    let getResponse _ = Console.ReadLine() 

    let spaceSeparatedIntsToTuple (s: string) = 
            let ints = s.Split(' ') |> Array.map int
            (ints.[0], ints.[1])

    let convertRawTestCasesToData rawData = rawData |> List.map spaceSeparatedIntsToTuple

    let getTestCase numTestCases = 
            let numberOfPairsInTestCase = getResponse () |> int
            let pairs = List.init numberOfPairsInTestCase (fun x -> getResponse ())
            convertRawTestCasesToData pairs

    let numberOfTestCases = getResponse () |> int

    let testCases = List.init numberOfTestCases getTestCase

    let doesTestCaseRepresentFunction testCase = 

            let xValueAlwaysHasSameYValue pair = 
                let xValue = fst pair
                let yValue = snd pair
                testCase 
                    |> List.filter (fun a -> fst a = xValue)
                    |> List.forall (fun b -> snd b = yValue)

            let isFunction = 
                    testCase 
                    |> List.map xValueAlwaysHasSameYValue 
                    |> List.forall (fun x-> x = true)
                    
            if isFunction  then printfn "YES" else printfn "NO"

    testCases |> List.iter doesTestCaseRepresentFunction |> ignore

    0
