using System;
using System.Collections.Generic;
using System.Text;

namespace _0311hmw
{
    class User
    { 
        private string _password;
        
       public string Password
        {
            get
            {
                return _password;
            }
            set
            { bool passCheck = PasswordCheck(value);
                
                if (passCheck == true)
                {
                     _password = value; 
                }
                else
                {
                    throw new PasswordIncorrectException("Yazdiginiz parol qebul edile bilmez!!!");
                }
            }
        }
        private string _username;
       public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if(value.Length>5 && value.Length<26)
                { _username = value; }
                else
                {
                    throw new InvalidUserNameException("Yazdiginiz istifadeci adi verilmis araliqda deyil!!!");
                }
            }
        }
        public User(string username)
        {
            Username = username;
        }
        public virtual void ShowInfo ()
        {
            Console.WriteLine($"Username; {Username}, Password; {Password}");
        }
        public bool PasswordCheck (string word)
        {
            bool hasdigit = false;
            bool haslower = false;
            bool hasupper = false;
            bool has = false;
            foreach (var item in word)
            {
                if(char.IsDigit(item))
                { hasdigit = true; }
                if(char.IsLower(item))
                { haslower = true; }
                if(char.IsUpper(item))
                { hasupper = true; }
            } 
            if((hasupper==true && hasdigit == true && haslower == true) && (word.Length<26 && word.Length>7))
            { has =true; } 
            return has;
        }
    }
}   
