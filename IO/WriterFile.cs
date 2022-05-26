using System.Text.Json;

namespace IO
{
    public class WriterFile
    {
        public static void Write<T>(string file, List<T> content)
        {
            using var stream = new FileStream(file, FileMode.Open, FileAccess.Write);

            using var writer = new StreamWriter(stream);

            var _result = JsonSerializer.Serialize<List<T>>(content);
            writer.Write(_result);

            writer.Close();
          //  stream.Close();
        }
    }
}
