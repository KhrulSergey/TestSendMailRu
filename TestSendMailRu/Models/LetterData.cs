using System;

namespace TestSendMailRu
{
    public class LetterData
    {
        /// <summary>
        /// Отправитель письма
        /// </summary>
        public string Sender { get; internal set; }
        /// <summary>
        /// Получатель письма
        /// </summary>
        public string Recipient { get; internal set; }
        /// <summary>
        /// Тема (subject) письма
        /// </summary>
        public string Theme { get; internal set; }
        /// <summary>
        /// Текст письма
        /// </summary>
        public string Body { get; internal set; }
        /// <summary>
        /// Подпись автора письма
        /// </summary>
        public string Signature { get; internal set; }
    }
}
