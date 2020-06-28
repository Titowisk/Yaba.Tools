using System;

namespace Yaba.Tools.Validations
{
    public static class Validate
    {
        public static void NotNull(object obj, string message = "Object cannot be null")
        {
            if (obj == null)
                throw new ArgumentException(message);
        }

        public static void NotNullOrEmpty(string text, string message = "Text cannot be empty or null")
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException(message);
        }

        public static void IsTrue(bool condition, string message = "Condition must be true")
        {
            if (!condition)
                throw new ArgumentException(message);
        }
    }
}
