/// \file Genres.cs
/// \brief Genres

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// \brief Class of genres
    class Genres
    {
        /// \brief List of genres
        private List<string> types;

        public Genres()
        {
            types = new List<string>() { "Fantasy", "Sci-Fi", "Mystery", "Thriller", "Romance", "Crime", "Horror", "Adventure" };
        }

        /// \brief Gettng an element of genre list
        public string getGenre(int index)
        {
            return types[index];
        }

        /// \brief Gettng the size of genre list
        public int getSize()
        {
            return types.Count;
        }
    }
}
