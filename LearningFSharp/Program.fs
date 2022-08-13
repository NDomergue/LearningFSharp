open System
// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let main argv =
    let input = Console.Read()
    printfn "Hello from F# - %A" input
    0