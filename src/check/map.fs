module Map

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
    let primesMap = Seq.initInfinite ((+) 2) |> Seq.filter isPrimeNumber |> Seq.mapi (fun i p -> (i, p))
    let result = primesMap |> Seq.find (fun (i, _) -> i = 10001 - 1) |> snd
    printfn "%d" result
    0