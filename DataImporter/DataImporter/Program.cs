using DataImporter.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader reader = new DataReader();
            List<News> data = reader.Read("News.json");
                //AddComments();
                //UpdateComment();
            }

        public static void AddComments()
        {
            using(OnlineExamDB db = new OnlineExamDB())
            {

                Comment comment = new Comment();
                comment.CommentText = "Hello from Inna";
                comment.CreationDateTime = DateTime.Now;
                comment.ExerciseId = 2;
                comment.Rating = 50;
                comment.UserId = "03c8563b-3495-4691-8e4b-0db1d1767223";
                comment.UserName = "Test user name";

                db.Comments.Add(comment);

                
                db.SaveChanges();

            }
        }

        public static void UpdateComment()
        {
            using (OnlineExamDB db = new OnlineExamDB())
            {
                Comment existingComment = db.Comments.FirstOrDefault(com => com.CommentText == "Hello from Inna");

                if(existingComment != null)
                {
                    existingComment.Rating = 3;
                    db.SaveChanges();
                }
            }
        }
    }
}
