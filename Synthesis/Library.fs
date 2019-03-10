module Synthesis

let abelar i = i > 13 && i < 3097 && i % 12 = 0

let area b h = match b < 0.0 || h < 0.0 with
    |true -> failwith "invalid arg"
    |false -> 0.5 * b * h

let zollo i = match i < 0 with
    |true -> i * -1
    |false -> i * 2

let min a b = match a > b with 
    |true -> b
    |false -> a

let max a b = match a > b with
    |true -> a
    |false -> b

let ofTime h m s = (h * 60 * 60) + (m * 60) + (s)

let toTime s = match s < 0 with
    |true -> (0,0,0)
    |false -> 
    let mt = s/60 
    let seconds = s%60
    let hours = mt/60
    let minutes = mt%60
    (hours, minutes, seconds)



let rec digits i = match i >= 0 with 
    |false -> digits (i * -1)
    |true ->
    if i < 10 then 1 else 1 + digits (i / 10)

let minmax _ =
    failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"