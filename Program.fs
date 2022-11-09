open System

let hello() =
  printf "Enter your name : "

  let name = Console.ReadLine()
  
  printfn "Hello %s" name

hello()

Console.ReadKey() |> ignore
