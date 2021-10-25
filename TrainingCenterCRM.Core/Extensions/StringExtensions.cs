using System.IO;

namespace TrainingCenterCRM.Core.Extensions
{
    public static class StringExtensions
    {
        public static string NormalizeSearchString(this string search)
        {
            return search.Replace(",", "").Replace(".", "").Replace("?", "").Trim();
        }

        public static MemoryStream GetMemoryStreamFromString(this string str)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
