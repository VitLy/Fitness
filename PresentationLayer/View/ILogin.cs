using System;

namespace PresentationLayer
{
    public interface ILogin : IView
    {
        event EventHandler ButtonOkClick;
        event EventHandler CheckboxChanged;
       
        /// <summary>
        /// Получить логин
        /// </summary>
        /// <returns></returns>
        String GetLogin();

        /// <summary>
        /// Получить пароль
        /// </summary>
        /// <returns></returns>
        String GetPassword();

        /// <summary>
        /// Скрыть символы пароля ****
        /// </summary>
        /// <returns></returns>
        bool GetShowPasswordFlag();
        void SetViewPassword(bool flag);
    }
}