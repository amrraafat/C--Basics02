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