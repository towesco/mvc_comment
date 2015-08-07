using mvc_comment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            try
            {
                c.commentDate = DateTime.Now;
                Entities.commentTB.Add(c);
                Entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public List<commentTB> CommentList()
        {
            return Entities.commentTB.Where(a => a.commentReplyId == null).OrderByDescending(b => b.commentDate).ToList();
        }
    }
}