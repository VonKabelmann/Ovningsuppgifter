
//Övningsuppgift 1 

//string name;

//Console.WriteLine("Hello. What is your name?");
//name = Console.ReadLine();
//Console.WriteLine($"Hello {name}!");

//Övningsuppgift 2

//string passInput;
//var password = "supersecretpassword";

//Console.WriteLine("Hello user. Please input your password.");
//passInput = Console.ReadLine();
//if (passInput == password)
//{
//    Console.WriteLine("Correct password! Welcome!");
//}
//else
//{
//    Console.WriteLine("Incorrect password! Back off, intruder!");
//}

//Övningsuppgift 3 

//int inputNum;

//Console.WriteLine("Input a number.");
//while (!int.TryParse(Console.ReadLine(), out inputNum))     // While loop för som hanterar undantag när annat än en int anges
//{
//    Console.WriteLine("Invalid input.");
//    Console.WriteLine("Please input in integers only.");
//}
//if (inputNum == 100)
//{
//    Console.WriteLine("The number you've entered is equal to 100");
//}
//else if (inputNum < 100)
//{
//    Console.WriteLine("The number you've entered is less than 100");
//}
//else if (inputNum > 100)
//{
//    Console.WriteLine("The number you've entered is greater than 100");
//}

//Övningsuppgift 4 

//string name;
//int numInput;

//Console.WriteLine("Hello. What is your name?");
//name = Console.ReadLine();
//Console.WriteLine("Please input a number.");
//numInput = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < numInput; i++)
//{
//    Console.WriteLine($"Hello {name}!");
//}

//Övningsuppgift 5 

//int numInput;
//int numSum = 0;
//int numAmount = 0;
//double numMid;

//while (true)
//{
//    Console.WriteLine("Input a number: ");
//    if (Int32.TryParse(Console.ReadLine(), out numInput))
//    {
//        numSum = numSum + numInput;
//        numAmount++;
//        Console.WriteLine($"The sum of your numbers is: {numSum}");
//    }
//    else
//    {
//        numMid = Convert.ToDouble(numSum) / numAmount;
//        Console.WriteLine($"The middle value of your numbers is {numMid}");
//        break;
//    }
//}

//Övningsuppgift 6

int firstNum;
int secondNum;
char op;


while (true)
{
    Console.Write("Enter your first number: ");
    if (!Int32.TryParse(Console.ReadLine(), out firstNum))
    {
        Console.WriteLine("Invalid input.");
    }
    else
    {
        break;
    }
}
while (true)
{
    Console.Write("Please enter an operator ('/', '*', '+' '-'): ");
    if (Char.TryParse(Console.ReadLine(), out op))
    {
        if (op == '/' || op == '*' || op == '+' || op == '-')
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid operator!");
        }
    }
    else
    {
        Console.WriteLine("Invalid operator!");
    }
}
while (true)
{
    Console.Write("Enter your second number: ");
    if (!Int32.TryParse(Console.ReadLine(), out secondNum))
    {
        Console.WriteLine("Invalid input.");
    }
    else
    {
        break;
    }
}
if (op == '/')
{
    Console.WriteLine($"{firstNum} divided by {secondNum} is equal to {Convert.ToDouble(Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum))}");
}
else if (op == '*')
{
    Console.WriteLine($"{firstNum} multiplied by {secondNum} is equal to {firstNum * secondNum}");
}
else if (op == '+')
{
    Console.WriteLine($"{firstNum} plus {secondNum} is equal to {firstNum + secondNum}");
}
else if (op == '-')
{
    Console.WriteLine($"{firstNum} minus {secondNum} is equal to {firstNum - secondNum}");
}