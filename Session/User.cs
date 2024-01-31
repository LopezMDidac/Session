using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class User
    {
        public string Name;
        public int Age;
        public bool IsIntern;

        public User(string name, int age, bool isIntern) 
        {
            Name = name;
            Age = age;
            IsIntern = isIntern; 
        }

        public string GreetingMessage()
        {
            var msgBuilder = new StringBuilder();
            msgBuilder.AppendLine($"Hello {Name} with {Age} years old.");
            if (IsIntern)
            {
                msgBuilder.AppendLine("Glad to see you as new internal user");
            }
            else
            {
                msgBuilder.AppendLine("Welcome as guest");
            }
            msgBuilder.AppendLine("");
            return msgBuilder.ToString();
        }
    }
}
