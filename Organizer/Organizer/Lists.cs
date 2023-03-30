/// \file lists.cs
/// \brief Basic lists

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// \brief Class of a work (book, movie or a show), objects of which can be used to create lists
    class Work
    {
        private string Title;
        private string Creator;
        private string Genre;
        private int Rate;
        private string Review;
        private string Image;

        private string Progress;
        private bool Status;


        public Work() { }

        public string getTitle() { return Title; }

        public string getCreator() { return Creator; }

        public string getGenre() { return Genre; }

        public int getRate() { return Rate; }

        public string getReview() { return Review; }

        public string getImage() { return Image; }

        public string getProgress() { return Progress; }

        public bool getStatus() { return Status; }


        public void setCreator(string Creator) { this.Creator = Creator; }

        public void setTitle(string Title) { this.Title = Title; }

        public void setGenre(string Genre) { this.Genre = Genre; }

        public void setRate(int Rate) { this.Rate = Rate; }

        public void setReview(string Review) { this.Review = Review; }

        public void setImage(string Image) { this.Image = Image; }

        public void setProgress(string Progress) { this.Progress = Progress; }

        public void setStatus(bool Status) { this.Status = Status; }
    }

    /// \brief Class of unfinished list
    class UnfinishedList
    {
        private Work work;
        protected static List<Work> unfinishedList = new List<Work>();

        public UnfinishedList() { }

        public int getSize()
        {
            return unfinishedList.Count;
        }

        public List<Work> getList()
        {
            return unfinishedList;
        }

        /// \brief Getting a parameter of the lists's element
        /// \param [in] Name name of the parameter
        /// \return Param needed parameter
        public string getParam(int index, string param)
        {
            string Param;

            switch (param)
            {
                case "Title":
                    {
                        Param = unfinishedList[index].getTitle();
                        return Param;
                    }
                case "Progress":
                    {
                        Param = unfinishedList[index].getProgress();
                        return Param;
                    }
                case "Status":
                    {
                        Param = unfinishedList[index].getStatus().ToString();
                        return Param;
                    }
                default:
                    {
                        return "-------";
                    }
            }
        }

        /// \brief Adding an element to the list
        public void add(string Title, string Progress, bool Status)
        {
            work = new Work();
            work.setTitle(Title);
            work.setProgress(Progress);
            work.setStatus(Status);
            unfinishedList.Add(work);
        }

        /// \brief Editing an element in the list
        public void edit(int index, string Title, string Progress, bool Status)
        {
            work = new Work();
            work.setTitle(Title);
            work.setProgress(Progress);
            work.setStatus(Status);
            unfinishedList[index] = work;
        }

        /// \brief Deleting an element from the list
        public void remove(int index)
        {
            unfinishedList.RemoveAt(index);
        }

        /// \brief Writing the list to the file
        public virtual void printToFile() { }

        /// \brief Reading the list from the file
        public virtual void readFromFile() { }

    }

    /// \brief Class of rating list
    class RatingList
    {
        private Work work;
        protected static List<Work> rating = new List<Work>();

        public List<Work> getList()
        {
            return rating;
        }

        /// \brief Getting a parameter of the rating's element
        /// \param [in] Name name of the parameter
        /// \return Param needed parameter
        public string getParam(int index, string param)
        {
            string Param;

            switch (param)
            {
                case "Title":
                    {
                        Param = rating[index].getTitle();
                        return Param;
                    }
                case "Creator":
                    {
                        Param = rating[index].getCreator();
                        return Param;
                    }
                case "Genre":
                    {
                        Param = rating[index].getGenre();
                        return Param;
                    }
                case "Rate":
                    {
                        Param = rating[index].getRate().ToString();
                        return Param;
                    }
                case "Review":
                    {
                        Param = rating[index].getReview();
                        return Param;
                    }
                case "Image":
                    {
                        Param = rating[index].getImage();
                        return Param;
                    }
                default:
                    {
                        return "-------";
                    }
            }
        }

        public int getSize()
        {
            return rating.Count;
        }

        /// \brief Adding an element to the rating
        public void add(string Title, string Creator, string Genre, int Rate, string Review, string Image)
        {
            work = new Work();
            work.setTitle(Title);
            work.setCreator(Creator);
            work.setGenre(Genre);
            work.setRate(Rate);
            work.setReview(Review);
            work.setImage(Image);
            rating.Add(work);
        }

        /// \brief Editing an element in the rating
        public void edit(int index, string Title, string Creator, string Genre, int Rate, string Review, string Image)
        {
            work = new Work();
            work.setTitle(Title);
            work.setCreator(Creator);
            work.setGenre(Genre);
            work.setRate(Rate);
            work.setReview(Review);
            work.setImage(Image);
            rating[index] = work;
        }

        /// \brief Deleting an element from the rating
        public void remove(int index)
        {
            rating.RemoveAt(index);
        }

        /// \brief Writing rating to the file
        public virtual void printToFile() { }

        /// \brief Reading rating from the file
        public virtual void readFromFile() { }
    }

}