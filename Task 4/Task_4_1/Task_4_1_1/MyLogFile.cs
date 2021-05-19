using System.IO;

namespace Task_4_1_1
{
    public class MyLogFile
    {
        private FileInfo _logFile;

        public MyLogFile(string directoryPath)
        {
            DirectoryInfo _logFileDirectory = new DirectoryInfo(directoryPath + @"\log");
            _logFile = new FileInfo(directoryPath + @"\log" + @"\log.json");

            if (!_logFileDirectory.Exists)
            {
                _logFileDirectory.Create();
            }

            using (FileStream fileStream = new FileStream(_logFile.FullName, FileMode.OpenOrCreate)) { }
        }

        public string FullName
        {
            get => _logFile.FullName;
        }
    }
}
