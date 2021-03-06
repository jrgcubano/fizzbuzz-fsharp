let fizzbuzz numbers =
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
		
  List.map fizzbuzz_number numbers
  
let converted = fizzbuzz [1..100]
List.iter (printfn "%s") converted
