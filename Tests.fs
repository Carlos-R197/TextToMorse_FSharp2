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
let full_name_test () =
    Assert.Equal("-.-. .- .-. .-.. --- ...", text_to_morse("Carlos"))
