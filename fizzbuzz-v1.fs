let fizzbuzz_number n =
  let ``is fizz?`` n = n % 3 = 0
  let ``is buzz?`` n = n % 5 = 0
  let ``is fizzbuzz?`` n = (``is fizz?`` n) && (``is buzz?`` n)

  if ``is fizzbuzz?`` n then
    "FizzBuzz"
  else if ``is fizz?`` n then
    "Fizz"
  else if ``is buzz?`` n then
    "Buzz"
  else
    sprintf "%d" n
	
printfn "%b" ((fizzbuzz_number 1) = "1")
printfn "%b" ((fizzbuzz_number 3) = "Fizz")
printfn "%b" ((fizzbuzz_number 5) = "Buzz")
printfn "%b" ((fizzbuzz_number 12) = "Fizz")
printfn "%b" ((fizzbuzz_number 15) = "FizzBuzz")
printfn "%b" ((fizzbuzz_number 17) = "17")
