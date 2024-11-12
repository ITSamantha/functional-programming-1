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

let rec findMaxCycleTailRec n d maxD maxLen =
    if d >= n then
        maxD
    else
        let len = cycleLength d

        let newMaxD, newMaxLen =
            if len > maxLen then
                d, len
            else
                maxD, maxLen

        findMaxCycleTailRec n (d + 1) newMaxD newMaxLen



[<EntryPoint>]
let main _ =
    let result = findMaxCycleTailRec 1000 1 1 0
    printfn "%d" result
    0
