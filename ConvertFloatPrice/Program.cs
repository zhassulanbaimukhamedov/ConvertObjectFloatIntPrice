float price = 100.2f;
object objPrice = price;
int newPrice = (int)(float)objPrice;
// int newPrice = (int)objPrice; 
//// Exception: Unable to cast object of type System.Single to type System.Int32
// int newPrice = (int)(double)objPrice; 
//// Exception: Unable to cast object of type System.Single to type System.Int32
// int newPrice = objPrice; 
//// Cannot implicity(неявно) convert type object to int. An explicit converstion is exist, are you missing a cast(тип)?
Console.WriteLine(newPrice); 