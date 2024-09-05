using MongoDB.Driver.Search;

namespace CQRS.Core.Messages
{
   public abstract class Message
   {
        public Guid Id { get; set; }
   } 
}