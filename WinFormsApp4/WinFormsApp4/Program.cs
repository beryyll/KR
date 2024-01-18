namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Инициализация конфигурации приложения
            Application.Run(new MemoryGameForm2()); // Запуск формы MemoryGameForm2

        }
    }
}