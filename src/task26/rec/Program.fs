module task26rec

let cycleLength d =
    let rec findCycle pos remainders rem =
        match Map.tryFind rem remainders with
        | Some (start) -> pos - start
        | None ->
            let nextRem = (rem * 10) % d

            if nextRem = 0 then
                0
            else
                findCycle (pos + 1) (Map.add rem pos remainders) nextRem

    findCycle 0 Map.empty 1

let rec findMaxCycleRec n d maxD maxLen =
    if d >= n then
        maxD
    else
        let len = cycleLength d

        if len > maxLen then
            findMaxCycleRec n (d + 1) d len
        else
            findMaxCycleRec n (d + 1) maxD maxLen


[<EntryPoint>]
let main _ =
    let result = findMaxCycleRec 1000 1 1 0
    printfn "%d" result
    0
