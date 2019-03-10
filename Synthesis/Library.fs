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

let minmax i = 
    failwith "Not implemented"

let isLeap i = match i < 1582 with
    |true -> failwith "invalid year, must be greater than 1582"
    |false -> i % 4 = 0 && (i % 100 <> 0 || i % 400 = 0)
        

let month i = match i with
    |1 -> ("January", 31)
    |2 -> ("February", 28)
    |3 -> ("March", 31)
    |4 -> ("April", 30)
    |5 -> ("May", 31)
    |6 -> ("June", 30)
    |7 -> ("July", 31)
    |8 -> ("August", 31)
    |9 -> ("September", 30)
    |10 -> ("October", 31)
    |11 -> ("November", 30)
    |12 -> ("December", 31)
    |_ -> failwith "Invalid Arg, # must be between 1 and 12"

let rec toBinary i = match i >= 0 with 
    |false -> failwith "Invalid Arg, # below 0"
    |true -> 
        match i with
        | 0 | 1 -> string i
        | _ ->
        let b = string (i % 2)
        (toBinary (i / 2)) + b

let rec bizFuzz n =
    let acc3 = 0
    let acc5 = 0
    let acc35 = 0
    let count = 1
    let rec temp n count = 
        match (count < n) with 
        |false -> (acc3, acc5, acc35)
        |true -> 
            match count  % 3 = 0 with
                |true -> acc3 = acc3 + 1
                |false -> temp(count + 1)



let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"