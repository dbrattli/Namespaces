// Learn more about F# at http://fsharp.org

open Foo
open Foo.Bar

[<EntryPoint>]
let main argv =
    Say.hello "from F#!"
    Bar.Say.hello "from F#!"
    Foo.Bar.Say.hello "from F#!"

    0 // return an integer exit code
