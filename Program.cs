using System;
using System.Collections.Generic;

/*
--At the bottom of the Program file, define a Book type with some properties you might expect a book to have 
(Author, title, publishdate, number of pages, whatever you like...). 

--You can use the example at the bottom of chapter 9 as a guide if you're still learning the syntax.
at the top of the file (after using System;), create three instances of your Book class using the new keyword.
You can use the object initialize (the {}) to add values for each of those instances 
(for example {Title = "20,000 Leagues Under the Sea"}

--Add a constructor that allows you to set the properties on object creation.


You should now have compiler errors. What are your options for fixing the errors? 
Come up with at least two options, and then pick one solution and implement it.

--Create an empty List of Book s.
Use the Add method to add your three instances to the list.

--Iterate over the list and print "<Title> - by <Author>" or something like that for each iteration 
(react to this post with :book: when you've finished this step)

Bonus: Write a get-only Property for the class to create the string in Step 8 for you. 
The property can be called DisplayName
Bonus: Use your newly created property in the iteration you wrote in step 8 (react with :books: if you finish this step)
*/

//3 new instances
Book untamed = new Book("Glennon Doyle", "Untamed", new DateTime(2020, 08, 08), 100)
{
  
};

Book leavesOfGrass = new Book()
{
    Author = "Walt Whitman",
    Title = "Leaves of Grass",
    PublishDate = new DateTime(1970, 07, 07),
    NumberOfPages = 300,
};

Book becoming = new Book()
{
    Author = "Michelle Obama",
    Title = "Becoming",
    PublishDate = new DateTime(2015, 01, 01),
    NumberOfPages = 1000,
};

List<Book> booksList = new List<Book>();

booksList.Add(untamed);
booksList.Add(leavesOfGrass);
booksList.Add(becoming);


foreach (Book book in booksList)
{
    Console.WriteLine($"The book {book.Title} by {book.Author} has {book.NumberOfPages} pages.");
}




//book type defined with default properties
public class Book 
{
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumberOfPages { get; set; }

//constructor
public Book(string author, string title, DateTime publishDate, int numberOfPages)
{
    Author = author;
    Title = title;
    PublishDate = publishDate;
    NumberOfPages = numberOfPages;
}

//another constructor that doesnt require parameters
public Book(){}

}; 


