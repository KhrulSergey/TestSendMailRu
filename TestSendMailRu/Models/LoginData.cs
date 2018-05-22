using System;

namespace TestSendMailRu
{
    internal class LoginData
    {
        /// <summary>
        /// Полное имя ящика
        /// </summary>
        internal string Email { get; internal set; }
        /// <summary>
        /// Название учетной записи
        /// </summary>
        internal string DisplayName { get; internal set; }
        /// <summary>
        /// Ссылка на почтоый сервис
        /// </summary>
        internal string UrlMailLink { get; internal set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        internal string UserName { get; internal set; }
        /// <summary>
        /// Пароль
        /// </summary>
        internal string Password { get; internal set; }
    }
}
