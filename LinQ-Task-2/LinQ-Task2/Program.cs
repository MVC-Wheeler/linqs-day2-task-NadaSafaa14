using System;

namespace Library;
class Program
{
    static void Main(string[] args)
    {
        List<Author> authors = new List<Author>()
        {
            new Author { Id = 1, Name = "Ahmed Khaled Tawfik" },
            new Author { Id = 2, Name = "Taha Hussein" },
            new Author { Id = 3, Name = "Naguib Mahfouz" }
        };

        List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "Utopia", Pages = 320, AuthorId = 1 },
            new Book { Id = 2, Title = "The Days", Pages = 250, AuthorId = 2 },
            new Book { Id = 3, Title = "Palace Walk", Pages = 400, AuthorId = 3 },
            new Book { Id = 4, Title = "Poor", Pages = 180, AuthorId = 1 },
            new Book { Id = 5, Title = "Paradise", Pages = 350, AuthorId = 2 }
        };

        // q1
        Console.WriteLine("q1:");
        var q1 = books.Where(b => b.Pages > 300);
        foreach (var b in q1)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q2
        Console.WriteLine("q2:");
        var q2 = books.Where(b => b.AuthorId == 1);
        foreach (var b in q2)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q3
        Console.WriteLine("q3:");
        var q3 = books.Where(b => b.Pages >= 200 && b.Pages <= 350);
        foreach (var b in q3)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q4
        Console.WriteLine("q4:");
        var q4 = books.Where(b => b.Title.StartsWith("P"));
        foreach (var b in q4)
        {
            Console.WriteLine(b);
        }

        Console.WriteLine();
        Console.WriteLine();
        // q5
        Console.WriteLine("q5:");
        var q5 = books.Select(b => b.Title);
        foreach (var t in q5)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q6
        Console.WriteLine("q6:");
        var q6 = books.Select(b => new { b.Title, b.Pages });
        foreach (var b in q6)
        {
            Console.WriteLine(b.Title + " " + b.Pages);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q7
        Console.WriteLine("q7:");
        var q7 = authors.Select(a => a.Name);
        foreach (var a in q7)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q8
        Console.WriteLine("q8:");
        var q8 = books.First(b => b.Pages > 300);
        Console.WriteLine(q8);
        Console.WriteLine();
        Console.WriteLine();
        // q9
        Console.WriteLine("q9:");
        var q9 = books.FirstOrDefault(b => b.AuthorId == 2);
        Console.WriteLine(q9);
        Console.WriteLine();
        Console.WriteLine();
        // q10
        Console.WriteLine("q10:");
        var q10 = authors.Single(a => a.Id == 3);
        Console.WriteLine(q10);
        Console.WriteLine();
        Console.WriteLine();
        // q11
        Console.WriteLine("q11:");
        var q11 = books.Single(b => b.Title == "Utopia");
        Console.WriteLine(q11);
        Console.WriteLine();
        Console.WriteLine();
        // q12
        Console.WriteLine("q12:");
        var q12 = books.OrderBy(b => b.Pages);
        foreach (var b in q12)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q13
        Console.WriteLine("q13:");
        var q13 = books.OrderByDescending(b => b.Title);
        foreach (var b in q13)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q14
        Console.WriteLine("q14:");
        var q14 = books.OrderBy(b => b.AuthorId).ThenBy(b => b.Pages);
        foreach (var b in q14)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();
        // q15
        Console.WriteLine("q15:");
        Console.WriteLine(books.Count());
        Console.WriteLine();
        Console.WriteLine();
        // q16
        Console.WriteLine("q16:");
        Console.WriteLine(books.Average(b => b.Pages));
        Console.WriteLine();
        Console.WriteLine();
        // q17
        Console.WriteLine("q17:");
        Console.WriteLine(books.Max(b => b.Pages));
        Console.WriteLine();
        Console.WriteLine();
        // q18
        Console.WriteLine("q18:");
        Console.WriteLine(books.Any(b => b.Pages > 400));
        Console.WriteLine();
        Console.WriteLine();
        // q19
        Console.WriteLine("q19:");
        Console.WriteLine(books.All(b => b.Pages > 100));
        Console.WriteLine();
        Console.WriteLine();
        // q20
        Console.WriteLine("q20:");
        bool q20 = books.Select(b => b.Title).Contains("Utopia");
        Console.WriteLine(q20);
        Console.WriteLine();
        Console.WriteLine();
        // q21
        Console.WriteLine("q21:");
        var q21 = books.Join(authors,
            b => b.AuthorId,
            a => a.Id,
            (b, a) => new { b.Title, a.Name });
        foreach (var x in q21)
        {
            Console.WriteLine(x.Name + " " + x.Title);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q22
        Console.WriteLine("q22:");
        var q22 = books.Join(authors,
            b => b.AuthorId,
            a => a.Id,
            (b, a) => new { a.Name, b.Title, b.Pages });
        foreach (var x in q22)
        {
            Console.WriteLine(x.Name + " " + x.Title + " " + x.Pages);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q23
        Console.WriteLine("q23:");
        var q23 = books.GroupBy(b => b.AuthorId);
        foreach (var g in q23)
        {
            Console.WriteLine("AuthorId: " + g.Key + " Books: " + g.Count());
        }
        Console.WriteLine();
        Console.WriteLine();

        // q24
        Console.WriteLine("q24:");
        var q24 = books.GroupBy(b => b.AuthorId);
        foreach (var g in q24)
        {
            Console.WriteLine("AuthorId: " + g.Key);
            foreach (var b in g)
            {
                Console.WriteLine(b.Title);
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        // q25
        Console.WriteLine("q25:");
        var q25 = books.Take(3);
        foreach (var b in q25)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q26
        Console.WriteLine("q26:");
        var q26 = books.Skip(2);
        foreach (var b in q26)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q27
        Console.WriteLine("q27:");
        var q27 = books.Skip(2).Take(3);
        foreach (var b in q27)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q28
        Console.WriteLine("q28:");
        var q28 = books.TakeWhile(b => b.Pages < 300);
        foreach (var b in q28)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q29
        Console.WriteLine("q29:");
        var q29 = books.SkipWhile(b => b.Pages < 250);
        foreach (var b in q29)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q30
        Console.WriteLine("q30:");
        var q30 = books.Chunk(2);
        foreach (var group in q30)
        {
            Console.WriteLine("Group:");
            foreach (var b in group)
            {
                Console.WriteLine(b);
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        // q31
        Console.WriteLine("q31:");
        var q31 = books.Select(b => b.AuthorId).Distinct();
        foreach (var id in q31)
        {
            Console.WriteLine(id);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q32
        Console.WriteLine("q32:");
        List<string> list1 = new List<string>() { "Utopia", "Palace Walk", "Poor" };
        List<string> list2 = new List<string>() { "Poor", "Paradise", "Utopia" };
        var q32 = list1.Union(list2);
        foreach (var t in q32)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q33
        Console.WriteLine("q33:");
        var q33 = list1.Intersect(list2);
        foreach (var t in q33)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
        Console.WriteLine();

        // q34
        Console.WriteLine("q34:");
        var q34 = list1.Except(list2);
        foreach (var t in q34)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
        Console.WriteLine();


    }
}