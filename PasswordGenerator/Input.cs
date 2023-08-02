using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Input
    {
        public int GetSeed()
        {
            Console.WriteLine("Введите сид генерации: ");
        }

        public int GetLength()
        {
            Console.WriteLine("Введите желаемую длину пароля: ");
        }
    }
}
