using System;

namespace TestSendMailRu
{
    public class LoginData
    {
        /// <summary>
        /// Полное имя ящика
        /// </summary>
        public string Email { get; internal set; }
        /// <summary>
        /// Название учетной записи
        /// </summary>
        public string DisplayName { get; internal set; }
        /// <summary>
        /// Ссылка на почтоый сервис
        /// </summary>
        public string UrlMailLink { get; internal set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; internal set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; internal set; }
    }
}
