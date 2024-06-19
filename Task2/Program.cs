namespace Task2
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            //tapsiriq-2-1
            string[] ad = { "Aysel", "Ali", "Ayhan", "Banu", "Arif", "Cemil", "Anar", "sebine" };

            int sayi = ASay(ad);
            Console.WriteLine(sayi);

        }

        static int ASay(string[] ad)
        {
            int a = 0;

            foreach (string adlar in ad)
            {
                if (adlar.StartsWith("B"))
                {
                    a++;
                }
            }
            return a;





        }*/

        //tapsiriq-2-2
        /*static void Main(string[] args)
        {
            int[] saylar = { 1, 2, 3, 4, 5, 6 ,7,8};

            int sayboyuk = saylar.Max();
            int saykicik = saylar.Min();

            double orta = (sayboyuk + saykicik)/2.0;

            Console.WriteLine($"boyuk eded:{sayboyuk}");
            Console.WriteLine($"kicik eded:{saykicik}");
            Console.WriteLine($"boyuk ve kicik ededlerin ortasi:{orta}");











        }*/

        //tapsiriq-2-3
        static void Main(string[] args)
        {
            //int[] reqemler = { 2332, 4224, 5667, 4896 };
            Console.WriteLine("Dördreqemli natural ededi daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());

            if (PalindromYoxla(eded))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


    }

        static bool PalindromYoxla(int eded)
        {
            // Ədədin string şəklinə çevrilməsi
            string ededString = eded.ToString();

            // Ədədin tərsinin yaradılması
            char[] ededChars = ededString.ToCharArray();
            Array.Reverse(ededChars);
            string ededTersi = new string(ededChars);

            // Ədədin orijinalı ilə tərsinin müqayisəsi
            return ededString == ededTersi;
        }
    }




} 

