namespace fsharphackerrank

open System

module Operators =

    let mealCost = double (Console.ReadLine())
    let tipPercent = double (Console.ReadLine())
    let taxPercent = double (Console.ReadLine())

    let getPercentage = fun mealCost percent -> mealCost * (percent / double 100)

    let tip = getPercentage mealCost tipPercent

    let tax = getPercentage mealCost taxPercent

    let totalCost = mealCost + tip + tax

    let roundedCost = int (System.Math.Round totalCost)

    printfn "The total meal cost is %i dollars." roundedCost

