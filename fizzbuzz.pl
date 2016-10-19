use feature "say";

for my $n (1..100) {
    say $n % 15 == 0 ? "FizzBuzz"
      : $n %  3 == 0 ? "Fizz"
      : $n %  5 == 0 ? "Buzz"
      : $n;
}