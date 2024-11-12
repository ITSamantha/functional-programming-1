module task7map

let isPrimeNumber (number: int) : bool =
    let rec check (i: int) : bool =
        if number <= 1 then false
        elif number = 2 then true
        elif i * i > number then true
        elif number % i = 0 then false
        else check (i + 1)

    check 2

let findNthPrime (n: int) : int =
    let primesMap =
        Seq.initInfinite ((+) 2)
        |> Seq.filter isPrimeNumber
        |> Seq.mapi (fun i p -> (i, p))

    primesMap
    |> Seq.find (fun (i, _) -> i = n - 1)
    |> snd

[<EntryPoint>]
let main _ =
    let result = findNthPrime 10001
    printfn "%d" result
    0
