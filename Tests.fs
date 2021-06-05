module Tests

open System
open Xunit
open Library.KataProblem

[<Fact>]
let empty_string_test () =
    Assert.Equal("", text_to_morse(""))

[<Fact>]
let one_letter_test () =
    Assert.Equal("-.-.", text_to_morse("C"))

[<Fact>]
let name_test () =
    Assert.Equal("-.-. .- .-. .-.. --- ...", text_to_morse("Carlos"))

[<Fact>]
let full_name_test () =
    Assert.Equal("-.-. .- .-. .-.. --- ... / .-. --- --.- ..- .", text_to_morse("Carlos Roque"))

[<Fact>]
let full_sentence_test () =
    Assert.Equal(".... . .-.. .-.. --- --..-- / -- -.-- / -. .- -- . / .. ... / -.-. .- .-. .-.. --- ... / .-. --- --.- ..- . / .- -. -.. / .. / ... - ..- -.. -.-- / ... --- ..-. - .-- .- .-. . / . -. --. .. -. . . .-. .. -. --. .-.-.-", 
        text_to_morse("Hello, my name is Carlos Roque and i study software engineering."))
