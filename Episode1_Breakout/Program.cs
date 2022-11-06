int correctCode = 0;
int maxPositions = 100;
int currentNumber = 0;

while (currentNumber <= maxPositions)
{
    if (correctCode > maxPositions) { Console.WriteLine("Incorrect input!"); break; }
    if (currentNumber == correctCode) { Console.WriteLine("Opened lock with code " + currentNumber); break; }
    currentNumber++;
}