using ClassDefinitions.Helper;
using System.Reflection;

namespace ItemEditor.Helper
{
    public class LogFileHelper
    {
        static string LogFilePath = "Error_Log.txt";

        public void LogException(Exception ex)
        {
            // Ensure the exception is not null
            if (ex == null) return;

            string errorMessage = $"[{DateTime.Now}] [Log Level: {LogLevelEnum.Error}]: {ex.Message}{Environment.NewLine}  StackTrace : {ex.StackTrace}{Environment.NewLine}";

            try
            {
                File.AppendAllText(LogFilePath, errorMessage);
            }
            catch (Exception logEx)
            {
                MessageBox.Show($"Failed to write to log file: {logEx.Message}");
            }
        }

        public void LogException(string message)
        {
            string errorMessage = $"[{DateTime.Now}] [Log Level: {LogLevelEnum.Error}]: {message}{Environment.NewLine} ";

            try
            {
                File.AppendAllText(LogFilePath, errorMessage);
            }
            catch (Exception logEx)
            {
                MessageBox.Show($"Failed to write to log file: {logEx.Message}");
            }
        }

        public void LogWarning(string message)
        {
            string errorMessage = $"[{DateTime.Now}] [Log Level: {LogLevelEnum.Warning}]: {message}{Environment.NewLine}";

            try
            {
                File.AppendAllText(LogFilePath, errorMessage);
            }
            catch (Exception logEx)
            {
                MessageBox.Show($"Failed to write to log file: {logEx.Message}");
            }
        }

        public void LogInformation(string message)
        {
            string errorMessage = $"[{DateTime.Now}] [Log Level: {LogLevelEnum.Information}]: {message}{Environment.NewLine}";

            try
            {
                File.AppendAllText(LogFilePath, errorMessage);
            }
            catch (Exception logEx)
            {
                MessageBox.Show($"Failed to write to log file: {logEx.Message}");
            }
        }

        public void CreateLogFile()
        {
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), LogFilePath);

            try
            {
                if (File.Exists(LogFilePath))
                {
                    FileInfo fileInfo = new FileInfo(LogFilePath);

                    // Check if the file size is greater than 1MB (1MB = 1 * 1024 * 1024 bytes)
                    if (fileInfo.Length > 1 * 1024 * 1024)
                    {
                        // Re-create the file (this deletes the existing file and creates a new one)
                        File.Delete(LogFilePath);
                        File.Create(LogFilePath);
                        Console.WriteLine("File was larger than 1MB and has been re-created.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to write to log file: {ex.Message}");
            }
        }


        #region Messagebox

        public void ShowError(Exception exception)
        {
            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogException(exception);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogException(message);
        }

        public void ShowInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LogInformation(message);
        }
        public void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LogWarning(message);
        }

        public static DialogResult ShowQuestion(string question)
        {
            return MessageBox.Show(question, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        #endregion
    }
}
