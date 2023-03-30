/// \file Books.cs
/// \brief Books lists

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// \brief Class of unread books list
    class NotReadBooks : UnfinishedList
    {
        public NotReadBooks()
        {
        }

        /// \brief Writing a list of unread books to a file
        public override void printToFile()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Storage\Not Read Books.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < unfinishedList.Count; i++)
            {
                sw.WriteLine(unfinishedList[i].getTitle() + " |" + unfinishedList[i].getProgress() + " |" + unfinishedList[i].getStatus());
            }

            sw.Close();
        }

        /// \brief Reading a list of unread books from a file
        public override void readFromFile()
        {
            string path = Directory.GetCurrentDirectory() + @"\Storage\Not Read Books.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;

                unfinishedList.Clear();

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');

                    add(values[0].Trim(), values[1].Trim(), bool.Parse(values[2].Trim()));
                }
            }
        }

    }

    /// \brief Class of rated books list
    class RatedBooks : RatingList
    {
        public RatedBooks()
        {
        }

        /// \brief Writing a rating list of books to a file
        public override void printToFile()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Storage\Rated Books.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < rating.Count; i++)
            {
                sw.WriteLine(rating[i].getTitle() + " |" + rating[i].getCreator() + " |" + rating[i].getGenre() + " |" + rating[i].getRate() + " |" +
                    rating[i].getReview() + " |" + rating[i].getImage());
            }

            sw.Close();

        }

        /// \brief Reading a rating list of books from a file
        public override void readFromFile()
        {
            string path = Directory.GetCurrentDirectory() + @"\Storage\Rated Books.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;

                rating.Clear();

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');

                    add(values[0].Trim(), values[1].Trim(), values[2].Trim(), int.Parse(values[3].Trim()), values[4].Trim(), values[5].Trim());
                }
            }
        }
    }
}
