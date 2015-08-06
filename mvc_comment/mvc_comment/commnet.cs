using mvc_comment.Models;
using System;

namespace mvc_comment
{
    public class CommentApp
    {
        //Değiştir
        private mvcDBEntities1 Entities { get; set; }

        public CommentApp()
        {
            //Değiştir
            Entities = new mvcDBEntities1();
        }

        public bool CommentSave(commentTB c)
        {
            c.commentDate = DateTime.Now;
            Entities.commentTB.Add(c);
            Entities.SaveChanges();
            return true;
        }
    }
}