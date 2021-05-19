using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Task_4_1_1
{
    public class MyLogger
    {
        private static string _directoryPath;
        private static FileSystemWatcher _watcher;
        private static MyLogFile _logFile;
        private static DataContractJsonSerializer _jsonSerializer;
       
        public MyLogger(string directoryPath)
        {
            _directoryPath = directoryPath;
            _jsonSerializer = new DataContractJsonSerializer(typeof(List<FileVersion>));
            _logFile = new MyLogFile(directoryPath);
        }

        public void Observe()
        {
            _watcher = new FileSystemWatcher(_directoryPath);

            _watcher.NotifyFilter = NotifyFilters.LastWrite;
            _watcher.Changed += OnChanged;
            _watcher.Filter = "*.txt";
            _watcher.IncludeSubdirectories = true;
            _watcher.EnableRaisingEvents = true;

            Console.WriteLine("Observing...");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

            _watcher.Dispose();
        }

        public void GoBackToVersion(string filePath, string date)
        {
            string str = ReadFromLogFile()
                .Where(item => item.LastWriteTime == date)
                .Select(item => item.Version)
                .FirstOrDefault();

            using (StreamWriter fs = new StreamWriter(filePath, false, Encoding.Default))
            {
                fs.Write(str);
            }
        }

        public string[] SelectVersionsByPath()
        {
            var selectedVersions = ReadFromLogFile()
                .OrderBy(item => item.FilePath)
                .GroupBy(item => item.FilePath)
                .Select(item => item.Key)
                .ToArray();

            return selectedVersions;
        }

        public string[] SelectVersionsByDate(string filePath)
        {
            var selectedVersions = ReadFromLogFile()
                .Where(item => item.FilePath == filePath)
                .OrderBy(item => item.Date)
                .Select(item => item.LastWriteTime)
                .ToArray();

            return selectedVersions;
        }


        private static void SaveChangesToLogFile(FileVersion fileVersion)
        {
            List<FileVersion> fileVersions = ReadFromLogFile();

            fileVersions.Add(fileVersion);

            using (FileStream fs = new FileStream(_logFile.FullName, FileMode.Create, FileAccess.Write))
            {
                _jsonSerializer.WriteObject(fs, fileVersions);
            }
        }

        private static List<FileVersion> ReadFromLogFile()
        {
            List<FileVersion> fileVersions;

            using (FileStream fs = new FileStream(_logFile.FullName, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    fileVersions = (List<FileVersion>)_jsonSerializer.ReadObject(fs);
                }
                catch (SerializationException)
                {
                    fileVersions = new List<FileVersion>();
                }
            }

            return fileVersions;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            SaveChangesToLogFile(new FileVersion(e.FullPath));
        }
    }
}
