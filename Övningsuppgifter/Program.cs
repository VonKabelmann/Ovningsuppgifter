
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

//int firstNum;
//int secondNum;
//char op;


//while (true)
//{
//    Console.Write("Enter your first number: ");
//    if (!Int32.TryParse(Console.ReadLine(), out firstNum))
//    {
//        Console.WriteLine("Invalid input.");
//    }
//    else
//    {
//        break;
//    }
//}
//while (true)
//{
//    Console.Write("Please enter an operator ('/', '*', '+' '-'): ");
//    if (Char.TryParse(Console.ReadLine(), out op))
//    {
//        if (op == '/' || op == '*' || op == '+' || op == '-')
//        {
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Invalid operator!");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid operator!");
//    }
//}
//while (true)
//{
//    Console.Write("Enter your second number: ");
//    if (!Int32.TryParse(Console.ReadLine(), out secondNum))
//    {
//        Console.WriteLine("Invalid input.");
//    }
//    else
//    {
//        break;
//    }
//}
//if (op == '/')
//{
//    Console.WriteLine($"{firstNum} divided by {secondNum} is equal to {Convert.ToDouble(Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum))}");
//}
//else if (op == '*')
//{
//    Console.WriteLine($"{firstNum} multiplied by {secondNum} is equal to {firstNum * secondNum}");
//}
//else if (op == '+')
//{
//    Console.WriteLine($"{firstNum} plus {secondNum} is equal to {firstNum + secondNum}");
//}
//else if (op == '-')
//{
//    Console.WriteLine($"{firstNum} minus {secondNum} is equal to {firstNum - secondNum}");
//}

////Övningsuppgift 7

//string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
//string monthInput1;
//string monthInput2;
//int monthIndex1;
//int monthIndex2;
//int monthDiff = 0;

//Console.Write("Input a month: ");
//while (true)
//{
//    monthInput1 = Console.ReadLine().ToLower();
//	if (Array.IndexOf(months, monthInput1) == -1)
//	{
//		Console.WriteLine("There is no such month.");
//		Console.Write("Please enter a valid month: ");
//	}
//	else
//	{
//        monthIndex1 = Array.IndexOf(months, monthInput1);
//        break;
//	}
//}
//Console.Write("Input a second month: ");
//while (true)
//{
//    monthInput2 = Console.ReadLine().ToLower();
//    if (Array.IndexOf(months, monthInput2) == -1)
//    {
//        Console.WriteLine("There is no such month.");
//        Console.Write("Please enter a valid month: ");
//    }
//    else
//    {
//        monthIndex2 = Array.IndexOf(months, monthInput2);
//        break;
//    }
//}
//Console.WriteLine($"The first month you entered is {monthInput1} and it is month number {monthIndex1 + 1}.");
//Console.WriteLine($"The second month you entered is {monthInput2} and it is month number {monthIndex2 + 1}.");
//monthDiff = monthIndex1 - monthIndex2;
//if (monthDiff < 0)
//{
//    monthDiff = monthDiff * -1;
//}
//if (monthDiff > 6)
//{
//    if (monthIndex1 < monthIndex2)
//    {
//        monthDiff = monthIndex1 + 12 - monthIndex2;
//    }
//    else if (monthIndex1 > monthIndex2)
//    {
//        monthDiff = monthIndex2 + 12 - monthIndex1;
//    }
//}
//Console.WriteLine($"The difference between the two months is {monthDiff}");

//Övningsuppgift 8
//Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad). 
//Fortsätt till du skrivit ut 16 rader.


//int value = 1;

//for (int i = 0; i < 16; i++)
//{
//    Console.WriteLine(value);
//    value = value * 2;
//}

//    Övningsuppgift 9
//    Skriv ett program som frågar användaren efter ett tal mellan 1 och 100. 
//    Programmet ska ha ett hemligt tal lagrat i en variabel. 
//    Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet. 
//    Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det. 
//    Exempel: programmet har det hemliga talet 27. Användaren gissar på 50. 
//    Programmet skriver ut att användaren gissade för högt. Användaren gissar på 20. 
//    Programmet skriver ut att det var för lågt. Användaren gissar på 27. 
//    Programmet skriver ut att det var rätt och avslutas.

//    Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på google hur det fungerar). 
//    Spara antalet gissningar i en variabel och skriv ut det när användaren gissat rätt.

Random randomNum = new Random();
int correctNum;
int numInput;
int guessAmount = 0;
int guessMax = 100;
int guessMin = 1;

correctNum = randomNum.Next(guessMin, guessMax);
// Console.WriteLine($"The correct number is: {correctNum}"); // för debug
Console.WriteLine("The goal of this game is to guess the secret number between 1 to 100.");
while (true)
{
	Console.Write($"Please enter a number between {guessMin} and {guessMax}: ");
	while (Int32.TryParse(Console.ReadLine(), out numInput))
	{
		if (numInput < guessMin || numInput > guessMax || numInput == 0)
		{
			Console.WriteLine($"Invalid entry. You must enter a number between {guessMin} and {guessMax}.");
			Console.Write($"Please enter a number between {guessMin} and {guessMax}: ");
		}
		else
		{
			guessAmount++;
			break;
		}
	}
	if (numInput == correctNum)
	{
		Console.WriteLine("Congratulations! You've guessed the correct number!");
		break;
	}
	else if (numInput > correctNum)
	{
		guessMax = numInput;
		Console.WriteLine($"Incorrect. The number is lower than {numInput}");
	}
	else if (numInput < correctNum && numInput != 0)
	{
		guessMin = numInput;
		Console.WriteLine($"Incorrect. The number is higher than {numInput}");
	}
}

//    Extra utmaning 2: skriv ett sten-sax-påse spel. 
//    Användaren skriver in “sten”, “sax” eller “påse”. Dators val slumpas med Random. 
//    Skriv sedan ut vad datorn valde, och vem som vann omgången. 
//    Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). 
//    Skriv även ut poäng.

