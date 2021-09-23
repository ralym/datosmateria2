open System

let functionmulti x y =
  let mutable suma=0
  for i in (1) .. (y) do
    suma<-suma+x
  suma


[<EntryPoint>]
let main argv =
    
    
    printfn "multiplicaacion mediante suma"
    printfn "digite valor a"
    let x = int(Console.ReadLine());
    printfn "digite valor b"
    let y = int(Console.ReadLine());
    let a=functionmulti x y
    printfn "Multipliacion: %i * %i  =%i" x y a
    
    0 // return an integer exit code
