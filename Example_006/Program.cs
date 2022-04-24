int numberA = 10;
int numberB = 9;
int numberC = 7;
int numberD = 5;
int numberE = 4;
int numberF = 3;
int max = numberA;

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;
if(numberD > max) max = numberD;
if(numberE > max) max = numberE;
if(numberF > max) max = numberF;

Console.Write("Max= ");
Console.WriteLine(max);