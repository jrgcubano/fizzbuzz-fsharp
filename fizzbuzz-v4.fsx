let add n u = 
  n + u
  
let rec iter f from until =
  if from < until then
    f from
    iter f (add from 1) until
  else
    f from	
		
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
	
let fizzbuzz from until =
  let convert_number i =
    let v = fizzbuzz_number i
    printfn "%s" v

  iter convert_number from until
  
fizzbuzz 1 100
