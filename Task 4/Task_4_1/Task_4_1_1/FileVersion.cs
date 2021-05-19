using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Task_4_1_1
{
    [DataContract]
    public class FileVersion
    {
        [DataMember]
        public readonly string LastWriteTime;
        [DataMember]
        public readonly string Version;
        [DataMember]
        public readonly string FilePath;

        private DateTime _date;

        public FileVersion(string path)
        {
            FilePath = path;
            FileInfo file = new FileInfo(path);

            _date = file.LastWriteTime;
            LastWriteTime = _date.ToString();

            while(Version == string.Empty || Version == null)
            {
                ReadVersion(file, out Version);
            }
        }

        public DateTime Date
        {
            get
            {
                if (_date != default)
                {
                    return _date;
                }
                else
                {
                    if (
                    DateTime.TryParse(LastWriteTime, out _date))
                    {
                        return _date;
                    }
                    else
                    {
                        return default;
                    }
                }
            }
        }

        private static void ReadVersion(FileInfo file, out string version)
        {
            try
            {
                using (StreamReader reader = new StreamReader(file.FullName, Encoding.Default))
                {
                    version = reader.ReadToEnd();
                }
            }
            catch (IOException)
            {
                version = string.Empty;
            }
        }
    }
}
