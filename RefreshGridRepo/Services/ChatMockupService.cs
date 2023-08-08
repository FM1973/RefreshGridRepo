using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshGridRepo.Domain;
using RefreshGridRepo.Interfaces;

namespace RefreshGridRepo.Services
{
    public class ChatMockupService : IChatService
    {
        private List<Message> _messageRepository;


        public ChatMockupService()
        {
            _messageRepository = new List<Message>();
            GenerateTestData();
        }

        private void GenerateTestData()
        {
            var random = new Random(DateTime.Now.Microsecond);
            for (int i = 0; i < 200; i++)
            {
                var nextRandom = random.Next(0, 10);
                if (nextRandom <= 5)
                {
                    _messageRepository.Add(new Message()
                    {
                        Content = $"Message incoming - {200-i}",
                        Direction = MessageDirection.In,
                        Id = Guid.NewGuid().ToString(),
                        UpdatedAt = DateTimeOffset.Now.AddMinutes(i * -1)
                    });
                }
                else
                {
                    _messageRepository.Add(new Message()
                    {
                        Content = $"Message outgoing - {200-i}",
                        Direction = MessageDirection.Out,
                        Id = Guid.NewGuid().ToString(),
                        UpdatedAt = DateTimeOffset.Now.AddMinutes(i * -1)
                    });
                }
            }
        }

        public async Task<Tuple<int, List<Message>>> GetMessagesAsync(int take, int skip)
        {
            await Task.Delay(250);
            var total = _messageRepository.Count();
            var messages = _messageRepository.OrderByDescending(c => c.UpdatedAt).Skip(skip).Take(take).ToList();
            return new Tuple<int, List<Message>>(total, messages);
        }
    }
}
