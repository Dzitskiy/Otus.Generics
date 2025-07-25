using System;

namespace Otus.Generics.Demo
{
    // интерфейс настройки консоли
    public interface IConsoleSettings
    {
        public ConsoleColor Foreground { get; }

        public ConsoleColor Background { get; }

    }

    /// <summary>
    /// Красно-зеленые настройки
    /// </summary>
    class RedAndGreenSettings : IConsoleSettings
    {
        public ConsoleColor Foreground => ConsoleColor.Green;

        public ConsoleColor Background => ConsoleColor.Red;
    }


    /// <summary>
    /// Фиолетовые и красные настройки
    /// </summary>
    class CyanAndWhiteSettings  : IConsoleSettings
    {
        public ConsoleColor Foreground => ConsoleColor.Cyan;

        public ConsoleColor Background => ConsoleColor.White;
    }


    /// <summary>
    /// Класс для цветного текста
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConsoleFormatter<T> where T : IConsoleSettings
    {
        private readonly T _settings;
        public ConsoleFormatter(T st)
        {
            _settings = st;
        }

        public void WriteColored(string s)
        {
            var defaultColors = new { F = Console.ForegroundColor, B = Console.BackgroundColor };

            Console.ForegroundColor = _settings.Foreground;
            Console.BackgroundColor = _settings.Background;

            Console.WriteLine(s);

            Console.ForegroundColor = defaultColors.F;
            Console.BackgroundColor = defaultColors.B;
        }
    }

    public class ClassConstraintsDemo : IBaseDemo
    {
        public void Show()
        {
            var rg = new CyanAndWhiteSettings();

            var cf = new ConsoleFormatter<CyanAndWhiteSettings>(rg);

            cf.WriteColored("Hello, world");

        }
    }

}