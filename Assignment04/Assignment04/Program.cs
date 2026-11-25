using Assignment04;
using System.ComponentModel;
#region Q1 to Q3
//Book book1 = new Book ();

//book1.Password = "secret"; // This line will cause a compilation error because 'password' is a private field and cannot be accessed outside the 'Book' class.
//book1.copiesInStock = 5; //  it will execute successfully because 'copiesInStock' is an internal field and can be accessed within the same assembly.
//book1.Title = "C# Programming";
////Console.WriteLine(book1.Password);
//Console.WriteLine(book1.copiesInStock);
//Console.WriteLine(book1.Title);
#endregion
#region Q4 To Q8
Book book = new Book();
Genre genre = Genre.Science;
Console.WriteLine(genre); //Q4
Console.WriteLine((int)Genre.Science);//Q5
Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
int genreNumber = 1;
Genre genreFromNumber = (Genre)genreNumber; //Q6
Console.WriteLine(genreFromNumber);
Genre genre1 = Genre.Fiction;
Console.WriteLine(genre1.ToString()); //Q7
string genreText = "Science";
Console.WriteLine(Enum.Parse<Genre>(genreText)); //Q8

#endregion
#region Q9
//string genreText = "Mystery";

//if (Enum.TryParse<Genre>(genreText, out Genre genre))
//{
//    Console.WriteLine(genre);
//}
//else
//{
//    Console.WriteLine("Unknown genre");
//}
#endregion
