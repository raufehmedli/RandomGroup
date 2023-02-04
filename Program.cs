namespace RandomGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insanlarin umumi sayini daxil edin: ");
            int umumiInsanSayi = Convert.ToInt32(Console.ReadLine()); // 10
            Console.Write("Her qrupda ne qeder insan olacagini daxil edin: ");
            int herQrupdakiInsanSayi = Convert.ToInt32(Console.ReadLine()); // 2

            List<string> insanlar = new();

            List<string> qrupUzvleri = new();
               

            for (int i = 1; i <= Convert.ToInt32(umumiInsanSayi); i++)
            {
                Console.Write($"{i}-ci istirakci: ");
                insanlar.Add(Console.ReadLine());
            }

            for (int i = 1; i <= umumiInsanSayi / herQrupdakiInsanSayi; i++)
            {
                while (umumiInsanSayi % herQrupdakiInsanSayi > 0)
                {
                    umumiInsanSayi++;
                    insanlar.Add("bosdur");
                }

                for (int j = 1; j <= herQrupdakiInsanSayi; j++)
                {
                    int sira = insanlar.Count - 1;
                    qrupUzvleri.Add(insanlar[sira]);
                    insanlar.Remove(insanlar[sira]);
                }
                string setr = $"Group {umumiInsanSayi/herQrupdakiInsanSayi-i+1} : [";
                for (int a = qrupUzvleri.Count-1;a>-1; a--)
                {
                    setr += $"'{qrupUzvleri[a]}', ";
                }
                setr = setr.Remove(setr.Length - 2, 2);
                setr += "]";
                Console.WriteLine(setr);
                qrupUzvleri.Clear();
            }
            //Console.Write("Insanlarin umumi sayini daxil edin: ");
            //int umumiInsanSayi = Convert.ToInt32(Console.ReadLine()); // 10
            //Console.Write("Her qrupda ne qeder insan olacagini daxil edin: ");
            //int herQrupdakiInsanSayi = Convert.ToInt32(Console.ReadLine()); // 2

            //List<string> insanlar = new();
            //List<string> qrupUzvleri = new();
            //Random random = new();

            //for (int i = 1; i <= Convert.ToInt32(umumiInsanSayi); i++)
            //{
            //    Console.Write($"{i}-ci istirakci: ");
            //    insanlar.Add(Console.ReadLine());
            //}

            //    while (insanlar.Count % herQrupdakiInsanSayi != 0)
            //    {
            //        insanlar.RemoveAt(random.Next(insanlar.Count));
            //    }


            //for (int i = 1; i <= umumiInsanSayi / herQrupdakiInsanSayi; i++)   // 10 / 3
            //{
            //    for (int j = 1; j <= herQrupdakiInsanSayi; j++)
            //    {
            //        int sira = random.Next(insanlar.Count - 1);
            //        qrupUzvleri.Add(insanlar[sira]);
            //        insanlar.Remove(insanlar[sira]);
            //    }
            //    string setr = $"Group {i} : [";
            //    for (int a = 0; a < qrupUzvleri.Count; a++)
            //    {
            //        setr += $"'{qrupUzvleri[a]}', ";
            //    }
            //    setr = setr.Remove(setr.Length - 2, 2);
            //    setr += "]";
            //    Console.WriteLine(setr);
            //    qrupUzvleri.Clear();
            //}
        }
    }

}