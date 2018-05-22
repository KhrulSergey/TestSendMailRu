using System;

namespace TestSendMailRu
{
    internal class LetterData
    {
        /// <summary>
        /// Отправитель письма
        /// </summary>
        internal string Sender { get; internal set; }
        /// <summary>
        /// Получатель письма
        /// </summary>
        internal string Recipient { get; internal set; }
        /// <summary>
        /// Тема (subject) письма
        /// </summary>
        internal string Theme { get; internal set; }
        /// <summary>
        /// Текст письма
        /// </summary>
        internal string Body { get; internal set; }
        /// <summary>
        /// Подпись автора письма
        /// </summary>
        internal string Signature { get; internal set; }
    }
}
