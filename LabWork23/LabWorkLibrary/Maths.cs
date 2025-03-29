namespace LabWorkLibrary
{
    /// <summary>
    /// Класс, содержащий математические методы.
    /// </summary>
    public static class Maths
    {
        /// <summary>Вычисляет сумму двух чисел.</summary>
        public static double Add(double a, double b) => a + b;

        /// <summary>Вычисляет разность двух чисел.</summary>
        public static double Subtract(double a, double b) => a - b;

        /// <summary>Вычисляет произведение двух чисел.</summary>
        public static double Multiply(double a, double b) => a * b;

        /// <summary>
        /// Вычисляет частное двух чисел.
        /// </summary>
        /// <param name="a">Делимое.</param>
        /// <param name="b">Делитель (не должен быть 0).</param>
        /// <returns>Результат деления.</returns>
        /// <exception cref="System.DivideByZeroException">Возникает при делении на 0.</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return a / b;
        }

        /// <summary>
        /// Вычисляет площадь прямоугольника.
        /// </summary>
        /// <param name="width">Ширина.</param>
        /// <param name="height">Высота.</param>
        /// <returns>Площадь прямоугольника.</returns>
        /// <exception cref="System.ArgumentException">Возникает при отрицательных или нулевых значениях.</exception>
        public static double RectangleArea(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Ширина и высота должны быть больше 0.");
            return width * height;
        }

        /// <summary>Коэффициент перевода в бинарную систему (1024).</summary>
        public const int BINARY_FACTOR = 1024;

    }
}