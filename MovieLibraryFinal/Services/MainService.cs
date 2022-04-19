using MovieLibraryFinal.DataAccessObjects;
using MovieLibraryFinal.DataObjects;

namespace MovieLibraryFinal.Services;

public class MainService : IMainService
{
    private readonly IFileService _fileService;
    private readonly ISearchService _searchService;
    private readonly IMovieLibraryContext _movieLibraryContext;
    private readonly IMovieLibrary _movieLibrary;

    public MainService(IFileService fileService, ISearchService searchService, IMovieLibraryContext movieLibraryContext)
    {
        _fileService = fileService;
        _searchService = searchService;
        _movieLibraryContext = movieLibraryContext;
        _movieLibrary = new MovieLibrary();
    }
    
    public void Invoke()
    {
        string choice;

        do
        {
            Console.WriteLine(/*FILL*/);
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SearchMovie();
                    break;
                case "2":
                    AddMovie();
                    break;
                case "3":
                    UpdateMovie();
                    break;
                case "4":
                    DeleteMovie();
                    break;
                default:
                    choice = "x";
                    break;
            }
        } while (!choice.Equals("x"));
    }
    
    private void SearchMovie()
    {
        throw new NotImplementedException();
    }
    
    private void AddMovie()
    {
        throw new NotImplementedException();
    }

    private void UpdateMovie()
    {
        throw new NotImplementedException();
    }

    private void DeleteMovie()
    {
        throw new NotImplementedException();
    }
}