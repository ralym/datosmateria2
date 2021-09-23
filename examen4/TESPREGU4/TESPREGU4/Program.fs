
open System

[<EntryPoint>]
let main argv = 
    let list1 = [ 187; 5778; 387; 48745; -66; 3; -68; 66 ;1597;1235]
    let listpares = []
    let listimpares = []
    printf "%A" list1
    let listpares = List.filter (fun x -> x % 2 = 0) list1 //añade pares 
    let listimpares = List.filter (fun x -> x % 2 = 1) list1   //añade impares
    printfn ""
    printfn "Lista Pares: %A" listpares //imprime
    printfn "Lista Impares: %A" listimpares
    Console.ReadKey() |>ignore
    0 // devuelve
    