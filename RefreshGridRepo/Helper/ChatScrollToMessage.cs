using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshGridRepo.Helper
{
    public class ChatScrollToMessage : ValueChangedMessage<MessagesToInfo>
    {
        public ChatScrollToMessage(MessagesToInfo value) : base(value)
        {
        }
    }

    public class MessagesToInfo
    {
        public int GroupIndex { get; set; }

        public int MessageIndex { get; set; }

        public bool ScrollToTop { get; set; }

        public bool Animate { get; set; }

        public MessagesToInfo(int groupIndex, int messageIndex, bool scrollToTop = false, bool animate = true)
        {
            GroupIndex = groupIndex;
            MessageIndex = messageIndex;
            ScrollToTop = scrollToTop;
            Animate = animate;
        }
    }
}
