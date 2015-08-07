using System.Linq;
using mvc_comment.Models;
using System;
using System.Collections.Generic;

namespace mvc_comment
{
    public class CommentApp
    {
        public class CommentListMetaData
        {
            public List<commentTB> RepyCommentList { get; set; }
        }

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
                return false;
            }
        }

        public List<commentTB> GetCommentList()
        {
            List<commentTB> list = (from c in Entities.commentTB
                                    where c.commentReplyId==null
                orderby c.commentDate descending
                select c).ToList();


            return list;
        }
    }
}