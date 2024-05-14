namespace BuildSphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere esfera = new Sphere(2, 50);

            Console.WriteLine(esfera.GetVolume());

        }
    }
}
