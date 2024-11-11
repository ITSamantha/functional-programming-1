let isPrimeNumber (number: int)  : bool = 
    let rec check  (i: int) : bool = 
        if number <= 1 then false
        elif number = 2 then true
        elif i * i > number then true
        elif number % i = 0 then false
        else check (i + 1)
    check 2

[<EntryPoint>]
let main _ =
    let primesSeq = Seq.initInfinite (fun x -> x + 2) |> Seq.filter isPrimeNumber  
    let result = primesSeq |> Seq.item (10001 - 1)
    printfn "%d" result
    0
