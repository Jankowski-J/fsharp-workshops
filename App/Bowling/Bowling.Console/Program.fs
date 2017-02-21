// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    argv 
    |> Array.iter (fun e ->printfn "%A" (bowling.bowlingScore e ))
    0 // return an integer exit code
