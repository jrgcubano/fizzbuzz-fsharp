let fizzbuzz_number = function
    | x when x % 3 = 0 && x % 5 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | x -> sprintf "%d" x
    
printfn "%b" ((fizzbuzz_number 1) = "1")
printfn "%b" ((fizzbuzz_number 3) = "Fizz")
printfn "%b" ((fizzbuzz_number 5) = "Buzz")
printfn "%b" ((fizzbuzz_number 12) = "Fizz")
printfn "%b" ((fizzbuzz_number 15) = "FizzBuzz")
printfn "%b" ((fizzbuzz_number 17) = "17")