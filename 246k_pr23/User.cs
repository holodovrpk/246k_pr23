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
                        return "Email не заполнен";

                    int n_at = Email.IndexOf("@");
                    int n_point = Email.IndexOf(".");
                    if (n_at == -1 || n_point == -1 || n_point < n_at)
                        return "Email не корректен";
                }

                return null;

            }
        }
    }
}
