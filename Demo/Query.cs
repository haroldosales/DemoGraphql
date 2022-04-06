public class Query
{
    public Book GetBook() =>
        new Book
        {
            nome = "Joao",
            Title = "C# in depth.",
            Ano = "1993",
            Capitulo =50,

            Author = new Author
            {
                Name = "Jon ",
                SobreNome = "Jack"
            }
        };
}
