using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshGridRepo.Domain;

namespace RefreshGridRepo.Interfaces
{
    public interface IChatService
    {
        /// <summary>
        /// Returns a tuple with the total count of messages and a list of messages
        /// </summary>
        /// <param name="take">How many messages to take</param>
        /// <param name="skip">How many messages to skip</param>
        /// <returns></returns>
        Task<Tuple<int,List<Message>>> GetMessagesAsync(int take, int skip);
    }
}
