#include <iostream>
#include <string>

int main()
{
  for(int c = 1; c <= 100; c++){
      std::string output;
      if(c % 3 == 0) output += "Fizz";
      if(c % 5 == 0) output += "Buzz";
      if(output.length() == 0) std::cout << c << std::endl;
      else std::cout << output << std::endl;
  }
}
