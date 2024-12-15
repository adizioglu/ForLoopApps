// for i in 0 .. 9 do
//     printfn "The value of i is %d" i

// let data = "Tim,Sue,Bob,Jane"
// let firstNames = data.Split(',') |> List.ofArray

// for i in 0 .. firstNames.Length - 1 do
//     printfn "%s is in attendance" firstNames.[i]

let charges = [23.78M; 15.89M; 125M]

let total = charges |> List.sum

printfn "Our total charge is %M" total
