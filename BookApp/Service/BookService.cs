using BookApp.Model;

namespace BookApp.Service;

public class BookService
{
    public readonly List<Book> Books = new()
    {
        new Book
        {
            Title = "Gregs Tagebuch von Idioten umzingelt!",
            Author = "Jeff Kinney",
            Price = 13.25,
            Description = "Greg hat von seiner Mutter ein Tagebuch geschenkt bekommen. Und das, obwohl Tagebücher doch eigentlich nur was für Mädchen sind! Oder etwa doch nicht? Greg jedenfalls beginnt einfach mal darin zu schreiben und zu zeichnen: über seine lästigen Brüder",
            Url = "QrCodes/Qr_GregsDiary.png",
            Image = "Products/GregsTagebuch.png"
        },
        new Book
        {
            Title = "C# FÜR DUMMIES",
            Author = "Steffen Steinbrecher",
            Price = 33.90,
            Description = "C# ist eine der am meisten genutzten Programmiersprachen, doch wie den Ein- oder Umstieg schaffen?",
            Url = "QrCodes/Qr_CSharpFuerDummies.png",
            Image = "Products/CSharpFuerDummies.png"
        },
        new Book
        {       
            Title = "SQL Grundkurs",
            Author = "Ralf Adams",
            Description = "Lernen Sie SQL ohne Datenbank-Vorkenntnisse Als Einsteiger",
            Url = "QrCodes/Qr_SqlGrundKurs.png",
            Image = "Products/SqlGrundKurs.png"
        },
        
        new Book
        {
            Title = "EINFACH BASISCH KOCHEN",
            Author = "Doris Muliar",
            Price = 18.80,
            Description = "Einfach, schnell und Gesund Kochen mit Kochbuch",
            Image = "Products/EinfachBasischKochen.png",
            Url = "QrCodes/Qr_EinfachBasischKochen.png"
        }
        
    };
}
