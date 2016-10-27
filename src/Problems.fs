module FEuler

let problem1 = 
    let filter x = x % 3 = 0 || x % 5 = 0
    Seq.filter filter {0..999} |> Seq.sum
