using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;


namespace Organizer
{
    /// \brief Controller for forms (call of existing forms or creating new ones)
    class Controller_Forms
    {
        //Objects of forms
        /// \brief Form for greeting
        private static UI_Greeting I_Greeting;
        /// \brief Form of starting menu
        private static UI_HomePage I_HomePage;
        /// \brief Form of books section
        private static UI_Books I_Books;
        /// \brief Form of shows section
        private static UI_Shows I_Shows;
        /// \brief Form of movies section
        private static UI_Movies I_Movies;
        /// \brief Form to add a work to the rating
        private static UI_Add I_Add;
        /// \brief Form to view information about a work
        private static UI_View I_View;
        /// \brief Form to edit and save information about a work
        private static UI_Edit I_Edit;

        /// \brief Index of currently used element of the list
        protected static int index;
        /// \brief Type of the work (book/movie/show)
        protected static string workType;

        /// \brief Creating form UI_Greeting
        public void greetingForm()
        {
            I_Greeting = new UI_Greeting();
            I_Greeting.ShowDialog();
        }

        /// \brief Creating form UI_Homepage
        public void homepageForm()
        {
            I_HomePage = new UI_HomePage();
            I_HomePage.ShowDialog();
        }

        /// \brief Creating form UI_Books
        public void booksForm()
        {
            I_Books = new UI_Books();
            I_Books.ShowDialog();
        }

        /// \brief Creating form UI_Shows
        public void showsForm()
        {
            I_Shows = new UI_Shows();
            I_Shows.ShowDialog();
        }

        /// \brief Creating form UI_Movies
        public void moviesForm()
        {
            I_Movies = new UI_Movies();
            I_Movies.ShowDialog();
        }

        /// \brief Creating form UI_Add
        public void addForm()
        {
            I_Add = new UI_Add();
            I_Add.ShowDialog();
        }

        /// \brief Creating form UI_View
        public void viewForm(int index_)
        {
            index = index_;
            I_View = new UI_View();
            I_View.ShowDialog();
        }

        /// \brief Creating form UI_Edit
        public void editForm()
        {
            I_Edit = new UI_Edit(index);
            I_Edit.ShowDialog();
        }

        /// \brief Returning to the previous form
        public void showPrevForm()
        {
            if (workType == "Books")
            {
                booksShow();
            }
            else if (workType == "Shows")
            {
                showsShow();
            }
            else if (workType == "Movies")
            {
                moviesShow();
            }
        }

        /// \brief Showing form UI_Greeting
        public void greetingShow()
        {
            I_Greeting.Show();
        }

        /// \brief Showing form UI_Homepage
        public void homepageShow()
        {
            I_HomePage.Show();
        }

        /// \brief Showing form UI_Books
        public void booksShow()
        {
            I_Books.Show();
        }

        /// \brief Showing form UI_Shows
        public void showsShow()
        {
            I_Shows.Show();
        }

        /// \brief Showing form UI_Movies
        public void moviesShow()
        {
            I_Movies.Show();
        }


    }

    /// \brief Main controller (processing and control of all events and actions)
    class Controller : Controller_Forms
    {
        private Genres genres = new Genres();

        /// \brief Basic rating
        private RatingList rating = new RatingList();
        /// \brief Rating table
        private DataTable rateTable = new DataTable();
        /// \brief Rated books
        private RatedBooks ratedBooks = new RatedBooks();
        /// \brief Rated shows
        private RatedShows ratedShows = new RatedShows();
        /// \brief Rated movies
        private RatedMovies ratedMovies = new RatedMovies();

        /// \brief Basic list
        private UnfinishedList list = new UnfinishedList();
        /// \brief Unfinished list table
        private DataTable listTable = new DataTable();
        /// \brief List of books
        private NotReadBooks booklist = new NotReadBooks();
        /// \brief List of shows
        private NotSeenShows showlist = new NotSeenShows();
        /// \brief List of movies
        private NotSeenMovies movielist = new NotSeenMovies();

        /// \brief Object for search
        private Search search = new Search();
        /// \brief Table with rating's results
        private DataTable resultRating = new DataTable();
        /// \brief Table with list's results
        private DataTable resultList = new DataTable();

        public Controller()
        {
        }

        public Controller(string type)
        {
            workType = type;
        }

        /// \brief Getting work's genre
        public string getGenres(int index)
        {
            return genres.getGenre(index);
        }

        public int genresSize()
        {
            return genres.getSize();
        }

        /// \brief Reading rating from the file
        public void readRating()
        {
            if (workType == "Books")
            {
                ratedBooks.readFromFile();
            }
            else if (workType == "Shows")
            {
                ratedShows.readFromFile();
            }
            else if (workType == "Movies")
            {
                ratedMovies.readFromFile();
            }

        }

        /// \brief Writing rating to the file
        public void writeRating()
        {
            if (workType == "Books")
            {
                ratedBooks.printToFile();
            }
            else if (workType == "Shows")
            {
                ratedShows.printToFile();
            }
            else if (workType == "Movies")
            {
                ratedMovies.printToFile();
            }

        }

        /// \brief Getting rating from the file
        public DataTable ratingLoad()
        {
            createRateTables();

            readRating();

            fillRateTable();

            return rateTable;
        }

        /// \brief Reloading rating from the file
        public DataTable ratingReload()
        {
            rateTable.Clear();
            fillRateTable();
            return rateTable;
        }

        /// \brief Creating columns of rating tables
        private void createRateTables()
        {
            rateTable.Columns.Add("Picture", typeof(Image));
            rateTable.Columns.Add("Title", typeof(string));
            rateTable.Columns.Add("Creator", typeof(string));
            rateTable.Columns.Add("Review", typeof(string));
            rateTable.Columns.Add("Genre", typeof(string));
            rateTable.Columns.Add("Rate", typeof(string));


            resultRating.Columns.Add("Picture", typeof(Image));
            resultRating.Columns.Add("Title", typeof(string));
            resultRating.Columns.Add("Creator", typeof(string));
            resultRating.Columns.Add("Review", typeof(string));
            resultRating.Columns.Add("Genre", typeof(string));
            resultRating.Columns.Add("Rate", typeof(string));
        }

        /// \brief Filling out the rating table from the file
        private void fillRateTable()
        {
            for (int i = 0; i < rating.getSize(); i++)
            {
                string path = rating.getParam(i, "Image");
                if (File.Exists(path))
                {
                    var image = Image.FromFile(path);
                    rateTable.Rows.Add(image, rating.getParam(i, "Title"), rating.getParam(i, "Creator"), rating.getParam(i, "Review"),
                    rating.getParam(i, "Genre"), rating.getParam(i, "Rate"));
                }
                else
                {
                    rateTable.Rows.Add(null, rating.getParam(i, "Title"), rating.getParam(i, "Creator"), rating.getParam(i, "Review"),
                     rating.getParam(i, "Genre"), rating.getParam(i, "Rate"));
                }

            }
        }

        /// \brief Deleting an element from the rating
        public void ratingRemoveAt(int index)
        {
            rating.remove(index);
            writeRating();
        }

        /// \brief Adding an element to the rating
        public void ratingAdd(string Title, string Creator, string Genre, int Rate, string Review, string Image)
        {
            rating.add(Title, Creator, Genre, Rate, Review, Image);
            writeRating();
        }

        /// \brief Getting a parameter of the rating's element
        public string ratingGetParam(string Name)
        {
            return rating.getParam(index, Name);
        }

        /// \brief Editing an element in the rating
        public void ratingEdit(string Title, string Creator, string Genre, int Rate, string Review, string Image)
        {
            rating.edit(index, Title, Creator, Genre, Rate, Review, Image);
            writeRating();
        }

        /// \brief Reading the list from the file
        public void readList()
        {
            if (workType == "Books")
            {
                booklist.readFromFile();
            }
            else if (workType == "Shows")
            {
                showlist.readFromFile();
            }
            else if (workType == "Movies")
            {
                movielist.readFromFile();
            }
        }

        /// \brief Writing the list to the file
        public void writeList()
        {
            if (workType == "Books")
            {
                booklist.printToFile();
            }
            else if (workType == "Shows")
            {
                showlist.printToFile();
            }
            else if (workType == "Movies")
            {
                movielist.printToFile();
            }
        }

        /// \brief Getting the list from the file
        public DataTable listLoad()
        {
            readList();

            createListTables();

            fillListTable();

            return listTable;
        }

        /// \brief Reloading the list from the file
        public DataTable listReload()
        {
            listTable.Clear();
            fillListTable();
            return listTable;
        }

        /// \brief Creating columns of list tables
        private void createListTables()
        {
            listTable.Columns.Add("Title", typeof(string));
            listTable.Columns.Add("Progress", typeof(string));
            listTable.Columns.Add("Status", typeof(bool));
            listTable.Columns.Add("Action", typeof(string));

            resultList.Columns.Add("Title", typeof(string));
            resultList.Columns.Add("Progress", typeof(string));
            resultList.Columns.Add("Status", typeof(bool));
            resultList.Columns.Add("Action", typeof(string));
        }

        /// \brief Filling out the list table from the file
        private void fillListTable()
        {
            for (int i = 0; i < list.getSize(); i++)
            {
                listTable.Rows.Add(list.getParam(i, "Title"), list.getParam(i, "Progress"),
                    bool.Parse(list.getParam(i, "Status")), "Delete");
            }
        }

        /// \brief Deleting an element from the list
        public void listRemoveAt(int index)
        {
            list.remove(index);
            writeList();
        }

        /// \brief Adding an element to the list
        public void listAdd(string Title, string Progress, bool Status)
        {
            list.add(Title, Progress, Status);
            writeList();
        }

        /// \brief Editing an element in the list
        public void listEdit(int index, string Title, string Progress, bool Status)
        {
            list.edit(index, Title, Progress, Status);
            writeList();
        }

        /// \brief Searching elements in the rating
        /// \param [in] line needed text
        public void searchRating(string line)
        {
            search.searchRating(ref resultRating, rating.getList(), line);

        }

        /// \brief Returning a result list from rating
        /// \return DataTable result of the search
        public DataTable getResultRating()
        {
            if (resultRating.Rows.Count != 0)
            {
                return resultRating;
            }

            return null;
        }

        /// \brief Searching elements in the list
        /// \param [in] line needed text
        public void searchList(string line)
        {
            search.searchList(ref resultList, list.getList(), line);
        }

        /// \brief Returning a result list from the list
        /// \return DataTable result of the search
        public DataTable getResultList()
        {
            if (resultList.Rows.Count != 0)
            {
                return resultList;
            }

            return null;
        }

    }

}
