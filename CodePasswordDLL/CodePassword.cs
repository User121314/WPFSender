﻿namespace CodePasswordDLL
{
    public class CodePassword
    {
        /// <summary>
        /// На вход подаем зашифрованный пароль, на выходе получаем пароль действительный
        /// </summary>
        /// <param name="p_sPassw"></param>
        /// <returns></returns>
        public static string getPassword(string p_sPassw)
        {
            string password = "";
            foreach (char a in p_sPassw)
            {
                char ch = a;
                ch--;
                password += ch;
            }

            return password;
        }

        /// <summary>
        /// На вход подаем пароль, на выходе получаем зашифрованный пароль
        /// </summary>
        /// <param name="p_sPassword"></param>
        /// <returns></returns>
        public static string getCodPassword(string p_sPassword)
        {
            string sCode = "";
            foreach (char a in p_sPassword)
            {
                char ch = a;
                ch++;
                sCode += ch;
            }
            return sCode;
        }
    }
}
