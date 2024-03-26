using System;
using SQLite;
namespace MovieApp.models
{
	public class Repository
	{
		private readonly SQLiteConnection _database;
		public Repository()
		{
			var dbpath = Path.Combine(
				Environment.GetFolderPath(
				Environment.SpecialFolder.LocalApplicationData),
				"movies.db");

			_database = new SQLiteConnection(dbpath);
			_database.CreateTable<Movie>();
		}

		public List<Movie> GetMovies()
		{
			return _database.Table<Movie>().ToList();
			//return _database.Query<Movie>("select * from Movie").ToList();
		}

		public void saveMovie(Movie movie)
		{
			_database.Insert(movie);
		}
	}
}

