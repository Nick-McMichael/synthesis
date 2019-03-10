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

let ofTime _ _ _ =
    failwith "Not implemented"

let toTime _ =
    failwith "Not implemented"

let digits _ =
    failwith "Not implemented"

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