// See https://aka.ms/new-console-template for more information
using Delegate;

Console.WriteLine("Hello, World!");


int option, result = 0;

Calculator obj = new Calculator();



MyDelegate1 delegate1;



Console.WriteLine("1.Add \b 2.Substract \n 3.Multiply \n 4.Divide");

Console.WriteLine("Select an option");

option = Convert.ToInt32(Console.ReadLine());



switch (option)

{

    case 1:



        delegate1 = new MyDelegate1(obj.Add);

        //delegate1 += new MyDelegate1(obj.Multiply);

        result = delegate1(10, 20);

        break;

    case 2:



        delegate1 = new MyDelegate1(obj.Substract);

        result = delegate1.Invoke(100, 20);

        break;



    case 3:



        delegate1 = new MyDelegate1(obj.Multiply);

        result = delegate1(10, 20);

        break;



    case 4:



        delegate1 = new MyDelegate1(obj.Divide);

        result = delegate1(100, 20);

        break;



    default:

        Console.WriteLine("Invalid choice");

        break;

}



Console.WriteLine($"Result = {result}");