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