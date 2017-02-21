open Suave

let scoreHandler (input: string) : WebPart =
    let scoreResult = Bowling.bowlingScore input
    match scoreResult with 
    | None -> RequestErrors.BAD_REQUEST "Wrong input"
    | Some x -> Successful.OK (x.ToString())

startWebServer defaultConfig (Filters.pathScan "/%s" scoreHandler)