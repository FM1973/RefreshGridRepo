using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshGridRepo.Domain
{
    public class Message
    {
        public string Id { get; set; }
        
        public string Content { get; set; }
        
        public MessageDirection Direction { get; set; }
     
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Richtung einer Nachricht
    /// </summary>
    public enum MessageDirection
    {
        /// <summary>
        /// Eingehend
        /// </summary>
        In = 1,
        /// <summary>
        /// Ausgehend
        /// </summary>
        Out = 2
    }
}
