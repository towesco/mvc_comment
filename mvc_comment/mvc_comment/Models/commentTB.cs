//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc_comment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class commentTB
    {
        public commentTB()
        {
            this.commentTB1 = new HashSet<commentTB>();
        }
    
        public int commentId { get; set; }
        public int commentUserId { get; set; }
        public System.DateTime commentDate { get; set; }
        public string commentNote { get; set; }
        public Nullable<int> commentReplyId { get; set; }
        public int commentExceptId { get; set; }
    
        public virtual ICollection<commentTB> commentTB1 { get; set; }
        public virtual commentTB commentTB2 { get; set; }
    }
}
