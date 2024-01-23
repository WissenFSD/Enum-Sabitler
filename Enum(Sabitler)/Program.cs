namespace Enum_Sabitler_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Enumlar kod içerisinde kullanılacak sabit değerleri temsil eder.
            // Enumlar sayesinde kodlarımız daha hatasız olur
            // Enumlar sayesinde kodlarımız daha kaliteli olmaktadır.

            // Enumlar sayesinde yazdığımız koda gelecekte geri dönüp baktığımızda daha kolay anlamamızı sağlayan yapılardır.
            Car c = new Car()
            {

                Name = "Renault",
                Type = "Binek",
            };
            
            Car c1 = new Car()
            {
                 Name="Man",
                 Type="Otobüs"

            };

            Car c2 = new Car()
            {

                Name = "Mercedes",
                Type = "Tır"
            };


            Araba a = new Araba()
            {
                Ad = "Peugeout",
                Type = CarType.Kamyonet

            };

            Araba a1 = new Araba()
            {

                Ad = "Mercedes",
                Type = CarType.Tır
            };
            
        }
    }
}