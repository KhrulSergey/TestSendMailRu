

Автотесты работают в браузерах: Firefox, Edge, Chrome

Для корректной работы необходимо следующее:

1. Подключение к интернету

2. Последние версии браузеров

---
Тест "SendLetterTest" находится в папке Tests
---

Настройка конфигурации работы автотеста автотеста осуществляются в файле Tests/DataProviders.
Возможные настройки:

1) BrowserType - Тип используемого браузера. Возможные значения (enum): "Chrome" (по-умолчанию), "edge", "firefox".

2) TestLogin: UserName, Password - Данные (логин и пароль) для входа в почту

3) TestLetterBody - параметры для отправки писем :

а) Recipient - Получатель

б) Theme - Тема письма

в) Body - Тело письма

г) Signature - Подпись отправителя
---
**Примечание**:  Тело письма по-умолчанию:
"Hello! 
This is a test letter. Please, do not answer.

@Developed by KhrulSA-Corp
---
