using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _246k_pr23
{
    public class User : IDataErrorInfo
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Name) && string.IsNullOrWhiteSpace(Name))
                    return "Имя не может быть пустым";

                if (columnName == nameof(Age) && (Age < 0 || Age > 120))
                    return "Возраст должен быть от 0 до 120";

                if (columnName == nameof(Email))
                {
                    if (string.IsNullOrWhiteSpace(Email))
                        return "Email не может быть пустым";

                    int in_at = Email.IndexOf("@");
                    int in_point = Email.IndexOf(".");

                    if (in_at == -1 || in_point == -1 || in_point < in_at)
                        return "Email имеет неверный формат";
                }

                return null;

            }
        }
    }
}

