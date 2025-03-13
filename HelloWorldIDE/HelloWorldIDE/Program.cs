//Console.WriteLine("Hello, World!");
//Console.ReadLine();

//int age = 25;
//long num = 24444444444444;
//float pi = 3.14f;
//double d = 3.123464445;
//char c = 'a';
//String s = "sohom";
//byte b = 23;
//sbyte sb = -30;
//short sh = -345;
//ushort ush = 200;
//Console.WriteLine($"age:{age} \nLong num:{num} \nFloat pi:{pi} \nDouble num:{d} \nCharacter:{c} \nString:{s} \nByte num:{b} \nsByte num:{sb} \nshort Num:{sh} \nUnsigned short Num:{ush}");

//String firstName = "Sohom";
//String lastName = "Das";
//Console.WriteLine(firstName + " " + lastName);

//int employeeId = 20;
//String companyName = "UTCLI";
//String lowerCompanyName = companyName.ToLower();
//String subStringcompanyName = companyName.Substring(2);

//Console.WriteLine($"Hello, my employee ID is {employeeId} and my company name is {companyName} {lowerCompanyName} {subStringcompanyName}");

//Reverse a string


using HelloWorldIDE;

//Console.WriteLine("Enter a String");
//string input = Console.ReadLine();


//char[] charArray = input.ToCharArray();
//Array.Reverse(charArray);
//string reversedString = new string(charArray);
//Console.WriteLine(reversedString);

//Methods method = new Methods();

//int v = method.sumOfTwoNumbers(2, 3);

//Console.WriteLine(v);

//Console.WriteLine("Enter a number");
//int input = 0;
//bool inputIsNotValid = true;
//while (inputIsNotValid)
//{
//    if (int.TryParse(Console.ReadLine(), out input))
//    {
//        inputIsNotValid = false;
//        break;
//    }
//    else
//    {
//        inputIsNotValid = true;
//        Console.WriteLine("Enter a valid number");
//    }
//}

//int returnValue=CheckPosition.PositionMethod(input);
//Console.WriteLine($"Student position is: {returnValue}");

//int sum2 = MethodOverloading.add(4, 5);
//Console.WriteLine($"This is from add 2 integers: {sum2}");
//int sum3 = MethodOverloading.add(4, 5, 6);
//Console.WriteLine($"This is from add 3 integers: {sum3}");
//string stringSum = MethodOverloading.add("Sohom", "Das");
//Console.WriteLine($"This is from String add {stringSum}");


//Console.WriteLine("Enter a number");
//int input = 0;
//bool inputIsNotValid = true;
//while (inputIsNotValid)
//{
//    if (int.TryParse(Console.ReadLine(), out input))
//    {
//        inputIsNotValid = false;
//        break;
//    }
//    else
//    {
//        inputIsNotValid = true;
//        Console.WriteLine("Enter a valid number");
//    }
//}

//Fibonacci.PrintFibonacciSeries(input);

//Console.WriteLine("Enter numerator");
//int numerator = 0;
//bool numeratorIsNotValid = true;
//while (numeratorIsNotValid)
//{
//    if (int.TryParse(Console.ReadLine(), out numerator))
//    {
//        numeratorIsNotValid = false;
//        break;
//    }
//    else
//    {
//        numeratorIsNotValid = true;
//        Console.WriteLine("Enter a valid number");
//    }
//}
//Console.WriteLine("Enter denominator");
//int denominator = 0;
//bool denominatorIsNotValid = true;
//while (denominatorIsNotValid)
//{
//    if (int.TryParse(Console.ReadLine(), out denominator))
//    {
//        denominatorIsNotValid = false;
//        break;
//    }
//    else
//    {
//        denominatorIsNotValid = true;
//        Console.WriteLine("Enter a valid number");
//    }
//}

//double result = TryCatch.TryCatchMethod(numerator, denominator);
//Console.WriteLine($"Result is: {result}");

Console.WriteLine("Enter length");
int l=int.Parse(Console.ReadLine());
Pattern3.pattern3(l);


