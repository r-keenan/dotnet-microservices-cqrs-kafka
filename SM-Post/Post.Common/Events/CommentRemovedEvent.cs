using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class CommentRemovedEvent: BaseEvent
    {
       public CommentRemovedEvent(): base(nameof(CommentRemovedEvent))
       {
        
       } 

       public Guid CommentId { get; set; }
    }
}