using ItemEditor.Forms;
using ItemEditor.Static;
using System.Text;
using UnhandledExceptionEventArgs = System.UnhandledExceptionEventArgs;
using UnhandledExceptionEventHandler = System.UnhandledExceptionEventHandler;

namespace ItemEditor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CoreServices.Logger.CreateLogFile();
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // Without this line there is error thrown. Whats intrestin Sucesfull connection to SQL DB solves the problem even without this line
            // ''EUC-KR' is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Application.Run(new MainForm());

        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            CoreServices.Logger.LogException(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            CoreServices.Logger.ShowError(e.ExceptionObject as Exception);
        }
    }
}