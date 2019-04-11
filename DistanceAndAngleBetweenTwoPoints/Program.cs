using System;
/// <summary>
/// В эту программу задаются две точки в системе координат X(по горизонтали)Y(по вертикали).
/// Программа вычисляет расстояние между точками, а так же на какой угол вокруг своей
/// оси требуется повернуться, находясь в первой точке, чтобы направиться ко второй точке.
/// Направление первой точки на оси координат - строго слева направо(эквивалентно оси Х).
/// </summary>
namespace DistanceAndAngleBetweenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем координаты первой точки с клавиатуры.
            Console.WriteLine("Поочередно напиши координаты первой точки по осям Х и Y");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            // Получаем координаты второй точки с клавиатуры.
            Console.WriteLine("Поочередно напиши координаты второй точки по осям Х и Y");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            //Считаем расстояние между точками по осям X и Y.
            float deltaX = x2 - x1; 
            float deltaY = y2 - y1;
            //Считаем фактическое расстояние между точками.
            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            //Считаем угол и переводим его в градусы
            float angle = (float)(Math.Atan2(deltaY, deltaX) * 180/Math.PI);
            //Выводим результат на экран
            //Обращу внимание, что отрицательный угол обозначает вращение по часовой
            //стрелке, а положительный - против часовой стрелки.
            Console.WriteLine("Расстояние между точками: {0}{2}Угол между точками: {1}",
                distance, angle, Environment.NewLine);
            Console.ReadKey();
        }
    }
}
