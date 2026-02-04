namespace KutuphaneYonetimSistemi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Color bgMain = ColorTranslator.FromHtml("#6E7173");
            Color accent = ColorTranslator.FromHtml("#D9BC9A");
            Color titleClr = ColorTranslator.FromHtml("#59402A");
            Color cardBg = ColorTranslator.FromHtml("#D9C3B0");
            Color textClr = ColorTranslator.FromHtml("#0D0D0D");
            Application.Run(new LoginForm());

        }
    }
}