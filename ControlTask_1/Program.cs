namespace ControlTask_1
{
    internal class Program
    {
        public static string FindSymLengthOfThree(string[] array)
        {
            string result = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    result = result + array[i] + " ";
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            string[] array = { "\"hello\"", "\"world\"", "\"2\"", "\")\"" };

            Console.WriteLine($"Элементы, длина которых меньше либо равна 3 символа:  {FindSymLengthOfThree(array)}");
        }
    }
}