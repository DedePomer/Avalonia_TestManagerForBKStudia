using System.IO;
namespace Avalonia_TestManagerForBKStudia.Infrastructure.Helpers
{
    public static class FileHelper
    {
        private static readonly string _extension = ".json";

        /// <summary>
        /// Метод проверяет существует ли тест с таким именем. Если существует, добавляет число к имени и проверяет ещё раз.
        /// Возвращает путь до теста
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetVerifyFilePath(string path, string fileName)
        {
            string fullFileName = fileName + _extension;
            int index = 1;
            string fullPath = Path.Combine(path, fullFileName);

            while (File.Exists(fullPath))
            {
                string newFileName = $"{fileName} ({index}){_extension}";
                fullPath = Path.Combine(path, newFileName);

                index++;
            }

            return fullPath;
        }
    }
}
