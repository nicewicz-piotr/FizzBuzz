using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] liczby = new string[101];
            for(int i =1; i < liczby.Length; i++){
                liczby[i] = i.ToString();
                
                if((int.Parse(liczby[i]) % 5 == 0) && (int.Parse(liczby[i]) % 3 == 0)){
                    liczby[i] = "FizzBuzz";
                    
                } else if(int.Parse(liczby[i]) % 3 == 0){
                    liczby[i] = "Fizz";
                   
                }
                else if(int.Parse(liczby[i]) % 5 == 0){
                    liczby[i] = "Buzz";

                }
            
                Console.Write($"{liczby[i]}, ");

            }
        }
    }
}
