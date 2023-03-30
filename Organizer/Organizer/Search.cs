/// \file Search.cs

using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;

namespace Organizer
{
    /// \brief Class of search to find word matched in lists
    class Search
    {
        public Search()
        {

        }

        /// \brief Search in the list
        /// \param [in] resultList the list of results
        /// \param [in] list list to searh in
        /// \param [in] line needed text
        public void searchList(ref DataTable resultList, List<Work> list, string line)
        {
            //Clearing out previous results
            resultList.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                //Title matches
                if (Boyer_Moore(list[i].getTitle(), line) == true)
                {
                    resultList.Rows.Add(list[i].getTitle(), list[i].getProgress(), list[i].getStatus());
                }
            }

        }

        /// \brief Search in the rating
        /// \param [in] resultRating the list of results
        /// \param [in] list list to searh in
        /// \param [in] line needed text
        public void searchRating(ref DataTable resultRating, List<Work> list, string line)
        {
            //Clearing out previous results
            resultRating.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                //Title or Creator matches
                if (Boyer_Moore(list[i].getTitle(), line) == true || Boyer_Moore(list[i].getCreator(), line) == true)
                {
                    var image = Image.FromFile(list[i].getImage());
                    resultRating.Rows.Add(image, list[i].getTitle(), list[i].getCreator(),
                        list[i].getReview(), list[i].getGenre(), list[i].getRate());
                }
            }

        }

        /// \brief Search by Boyer-Moore algorithm
        /// \param [in] line text for search
        /// \param [in] pattern needed text
        private bool Boyer_Moore(string line, string pattern)
        {
            try
            {
                int m = pattern.Length;
                int n = line.Length;
                int i;
                int[] badchar = new int[256];


                for (i = 0; i < 256; i++)
                    badchar[i] = -1;

                for (i = 0; i < m; i++)
                    badchar[(int)pattern[i]] = i;

                int s = 0;

                while (s <= (n - m))
                {
                    int j = m - 1;

                    while (j >= 0 && pattern[j] == line[s + j])
                        j--;

                    if (j < 0)
                    {
                        return true;

                    }

                    else
                        s += Math.Max(1, j - badchar[line[s + j]]);
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
