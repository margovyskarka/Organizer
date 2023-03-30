/// \file Shows.cs
/// \brief Shows lists

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// \brief Class of unseen shows list
    class NotSeenShows : UnfinishedList
    {
        public NotSeenShows()
        {
        }

        /// \brief Writing a list of unseen shows to a file
        public override void printToFile()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Storage\Not Seen Shows.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < unfinishedList.Count; i++)
            {
                sw.WriteLine(unfinishedList[i].getTitle() + " |" + unfinishedList[i].getProgress() + " |" + unfinishedList[i].getStatus());
            }

            sw.Close();
        }

        /// \brief Reading a list of unseen shows to a file
        public override void readFromFile()
        {
            string path = Directory.GetCurrentDirectory() + @"\Storage\Not Seen Shows.txt";

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

    /// \brief Class of rated shows list
    class RatedShows : RatingList
    {
        public RatedShows()
        {
        }

        /// \brief Writing a rating list of shows to a file
        public override void printToFile()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Storage\Rated Shows.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < rating.Count; i++)
            {
                sw.WriteLine(rating[i].getTitle() + " |" + rating[i].getCreator() + " |" + rating[i].getGenre() + " |" + rating[i].getRate() + " |" +
                    rating[i].getReview() + " |" + rating[i].getImage());
            }

            sw.Close();

        }

        /// \brief Reading a rating list of movies from a file
        public override void readFromFile()
        {
            string path = Directory.GetCurrentDirectory() + @"\Storage\Rated Shows.txt";

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
