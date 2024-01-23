namespace Enum_Degisken_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String ifadeyi Enum'a tipine çevirebilirsiniz.

            // Enum.Parse bu işe yarar

            // 
            var cumaGunu = Enum.Parse(typeof(Gunler), "Cuma");
            Console.WriteLine(cumaGunu);
            //Console.ReadLine();

            // Enum'in adını öğrenmek

            var enumName = Enum.GetName(typeof(Gunler), 11);

            Console.WriteLine(enumName);

            //Console.ReadLine();



            // Cast edilebilir int tipinde bir değeri enum tipine dönüştürebiliriz.

            int gun = 10;
            Gunler gunler = (Gunler)gun;



           int pazartesiint= (int)Gunler.Pazartesi;
            Console.WriteLine(pazartesiint);
            //Console.ReadLine();


            // tüm listede gezelim



            // Tüm enumlarda gezmek

            // Enum.GetNames tüm enumların isimlerini verir geriye string dizi döndürür
            foreach (var item in Enum.GetNames(typeof(Gunler)))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();



            // String'e çevirmek

            // Enum'ı string'e çevirebilirsiniz.
            string enumString = Gunler.Pazartesi.ToString();



        }


    }
}