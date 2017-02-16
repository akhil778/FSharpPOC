//namespace HelloWorld.Tests
//
//type Class1() = 
//    member this.X = "F#"

module HelloWorld.Tests.Hello

open HelloWorld.core.Hello
open NUnit.Framework
open FsUnit

[<Test>]
let shouldSayHello () = Assert.AreEqual("Hello World!", SayHello "World")

[<Test>]
let shouldSayHello2
    = fun () -> Assert.AreEqual("Hello World!", SayHello "World!")