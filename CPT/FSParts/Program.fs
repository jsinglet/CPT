﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "%d" (Stuff.add 1 2)
    0 // return an integer exit code


