#region Question 01 - Book Object and Storage in Object Variable
// Q1: Create a Book and put it in an object variable
Book myBook = new Book { Title = "C# Basics", Pages = 300 };
object objBook = myBook;
Console.WriteLine(objBook);
#endregion

#region Question 02 - System.Object Built in Methods
// Q2: Use default object methods on myBook
Console.WriteLine(myBook.ToString());
Console.WriteLine(myBook.Equals(myBook));
Console.WriteLine(myBook.GetHashCode());
Console.WriteLine(myBook.GetType());
#endregion

#region Question 03 - Compile-time Error Fix
// Q3: Fix the compile-time error
// Error was: int pages = "464"; (string cannot go into int)
int pages = 464;
Console.WriteLine(pages);
#endregion

#region Question 04 - Exception Handling
// Q4: Catch using try-catch-finally
try
{
    int number1 = 10;
    int number2 = 0;
    int result = number1 / number2;
}
catch
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
#endregion

#region Question 05 - Implicit Casting
// Q5: Put an int into a double
int pagesInt = 300;
double pagesDouble = pagesInt;
Console.WriteLine(pagesDouble);
#endregion

#region Question 06 - Explicit Casting
// Q6: Convert double to int using explicit cast (int)
double price = 49.99;
int priceInt = (int)price;
Console.WriteLine(priceInt);
#endregion

#region Question 07 - Convert Class
// Q7: Convert string to int using the Convert class
string pagesText = "464";
int page = Convert.ToInt32(pagesText);

Console.WriteLine(page);
#endregion

#region Question 08 - int.Parse and int.TryParse
// Q8: Parse valid string using int.Parse and handle invalid string using int.TryParse
string yearText = "2023";
int parsedYear = int.Parse(yearText);
Console.WriteLine(parsedYear);

string badText = "abc";
int safeNumber;
bool success = int.TryParse(badText, out safeNumber);

if (success == false)
{
    Console.WriteLine("Invalid number");
}
#endregion

#region Question 09 - Converting Number to String

// Q9: Make a number into a string and check its type
int pagesint = 464;
string strPages = pagesint.ToString();
Console.WriteLine(strPages.GetType());
#endregion

#region Question 10 - Boxing and Unboxing

// Q10: Box (put int in object) and Unbox (take int out of object)
int copies = 100;
object boxedCopies = copies;
int unboxedCopies = (int)boxedCopies;
Console.WriteLine(boxedCopies);
Console.WriteLine(unboxedCopies);

#endregion

#region Question 11 - which can hold null

// Q11: Use int? which can hold null
int? year = null;
Console.WriteLine(year.HasValue);

year = 2023;
Console.WriteLine(year.Value);
#endregion

#region Question 12 - Checking for Null Values

// Q12: Make a string null and check it
string? reviewer = null;
bool isNull = reviewer == null;
Console.WriteLine(isNull);

#endregion

#region Question 13 - Null-Conditional Operator

// Q13: Read property safely using ?. without crashing
Book? book = null;
string? title = book?.Title;
Console.WriteLine(title);
#endregion

#region Question 14 - Null-Coalescing Operator

// Q14: Set defaults if value is null
string? Title = null;

Console.WriteLine(Title ?? "Untitled");

Title ??= "Untitled";
Console.WriteLine(Title);
#endregion

#region Question 15 - Null-Forgiving Operator

// Q15: Tell the compiler
string? name = "Ahmed";
string confirmedName = name!;
Console.WriteLine(confirmedName);
#endregion

#region Book Class Definition
// Basic Book class for the assignment
/// <summary>
/// Represents a book entity used across the assignment tasks.
/// </summary>
/// <param name="title">The title of the book.</param>
/// <param name="pages">The number of pages in the book.</param>
class Book
{
    public string? Title;
    public int Pages;
}
#endregion