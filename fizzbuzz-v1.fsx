let fizzbuzz_number n =
  if n % 3 = 0 && n % 5 = 0 then
    "FizzBuzz"
  else if n % 3 = 0 then
    "Fizz"
  else if n % 5 = 0 then
    "Buzz"
  else
    sprintf "%d" n
	
fizzbuzz_number 10
