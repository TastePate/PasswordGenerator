using System;
using System.Text;

namespace PasswordGenerator
{
    public class Generator
    {
        private readonly string SYMBOLS = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()+-/|\\<>";
        private Random random;

        public Generator(int seed)
        {
            random = new Random(seed);
        }

        public Generator()
        {
            random = new Random();
        }

        public string Generate(int length)
        {
            if (length < 8)
                throw new IncorrectLength($"Пароль не может быть длины менее 8 символов. Ваша длина: {length}");
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(SYMBOLS.Length);
                password.Append(SYMBOLS[index]);
            }
            return password.ToString();
        }
    }
}
