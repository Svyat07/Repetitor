using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_15Repetitor_26_01_23.Entities
{
    public partial class Repetitor
    {
        public string FullName
        {
            get
            {
                var fullName = $"{LastName} {Name} ";
                if (string.IsNullOrWhiteSpace(Patronymic) == false)
                {
                    fullName += $"{ Patronymic}";
                }
                return fullName;

            }
        }
    }
}
