namespace StringToCamelCase
{
    internal class Program
    {

        public class kata
        {
            public static string ToCamelCase(string str)
            {
                char[] separadores = new char[2];
                separadores[0] = '_';
                separadores[1] = '-';
                string[] separarString = str.Split(separadores);

                string camelCase = separarString[0];
                Console.WriteLine(separarString);

                for (int i = 1;i < separarString.Length; i++){
                    camelCase+=separarString[i].Substring(0,1).ToUpper()+separarString[i].Substring(1).ToLower();
                }

                return camelCase;


            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(kata.ToCamelCase("hola_amigos-como-estan"));
        }
    }
}
