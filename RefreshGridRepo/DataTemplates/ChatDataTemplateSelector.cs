using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshGridRepo.Domain;

namespace RefreshGridRepo.DataTemplates
{
    public class ChatDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ChatIn { get; set; }

        public DataTemplate ChatOut { get; set; }

        /// <inheritdoc />
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = (Message)item;
            if (message.Direction == MessageDirection.In)
                return ChatIn;
            return ChatOut;
        }
    }
}
