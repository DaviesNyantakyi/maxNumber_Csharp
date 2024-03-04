using System;


class MyApp
{

    class Human
    {
        static void Main()
        {


          int result =   GetMaxNumber(2, 5);

            Console.WriteLine(result);
        }

        static int GetMaxNumber(int num1, int num2)
        {
           if(num1> num2)
            {
               return num1;
            }else
            {
                return num2;
            }
        }
    }
}
