using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshGridRepo.Domain;

namespace RefreshGridRepo.DataTemplates
{
    public class MessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MessageIn { get; set; }

        public DataTemplate MessageOut { get; set; }

        /// <inheritdoc />
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = (Message)item;
            if (message.Direction == MessageDirection.In)
                return MessageIn;
            return MessageOut;
        }
    }
}
