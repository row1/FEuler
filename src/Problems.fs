module FEuler

//Multiples of 3 and 5 = 233168
let problem1 = 
    let filter x = x % 3 = 0 || x % 5 = 0
    Seq.filter filter {0..999} |> Seq.sum

//Sum of even Fibonacci numbers under 4M = 4613732
let problem2 =
    let fib = Seq.unfold( fun(fst, snd) -> 
        Some(fst + snd, (snd, fst + snd))) (0, 1)

    Seq.filter (fun x -> x % 2 = 0) fib 
        |> Seq.takeWhile (fun x -> x < 4000000) 
        |> Seq.sum
