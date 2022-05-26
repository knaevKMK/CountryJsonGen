namespace IO
{
    using System.IO;
    using System.Text.Json;

    public class ReaderFile
    {
        public static List<T> Read<T>(string file)
        {
            using var stream = new FileStream(file, FileMode.Open, FileAccess.Read);

            using var reader = new StreamReader(stream);

            var data = reader.ReadToEnd();

            stream.Close();
            reader.Close();

            var getInfoFrom = JsonSerializer.Deserialize<List<T>>(data);

            return getInfoFrom;
        }
    }
}