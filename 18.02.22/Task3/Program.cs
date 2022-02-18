using System;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Extension method yaziriq, bir string qəbul edir,birde int gelir,
            //verilen eded tekdirse geriye sözü qaytarır, cütdürsə sözə 's əlaye edir qaytarir.  

            //string str = Console.ReadLine();
            //int num = 0;
            //int.TryParse(Console.ReadLine(), out num);


            //Console.WriteLine(str.AddExt(num));
            #endregion

            #region Task2
            //a)String ücün SecretBannedWords() extension method yazin, ona verilen banned sözləri "Oops"-lasin.
            //b)BannedWords addinda istifadesi qadağan olun string array yaradin və icini müxtəlif sözlərlə doldurun.

            //Console.WriteLine("Cumlenin uzunlugun daxil edin");
            //int.TryParse(Console.ReadLine(), out int a);

            //string[] cumle = new string[a];

            //Console.WriteLine("Cumleni daxil edin");

            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    cumle[i] = Console.ReadLine();
            //}

            //SoyusSoyme(cumle);
            #endregion

            #region Task3
            //int ücün Add(int x) extension method yazin, cağırarkən ötürülən rəqəmi üstünə gəlsin. 
            //Console.WriteLine("1ci ededi daxil edin");
            //int.TryParse(Console.ReadLine(), out int a);
            //Console.WriteLine("2ci ededi daxil edin");
            //int.TryParse(Console.ReadLine(), out int b);

            //Console.WriteLine($"{a.SumNum(b)} netice budur");


            #endregion

            #region Task4
            
            //Console.WriteLine("Kitabin Adini Daxil Edin:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Kitabin Qiymetini Daxil:");
            //double.TryParse(Console.ReadLine(), out double price);

            //foreach (var item in Enum.GetValues(typeof(ProductGenre)))
            //{
            //    Console.WriteLine($"{(byte)item} {item}");
            //}
            //int.TryParse(Console.ReadLine(), out int select);
            //ProductGenre Bookgenre = 0;
            //switch (select)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Bookgenre = (ProductGenre)select;
            //        break;

            //    default:
            //        break;
            //}

            //Book book1 = new Book(Bookgenre, price);
            //book1.BookName = name;

            //Console.WriteLine($"{book1.Id} {book1.BookName} {book1.Price} {book1.DiscountedPrice}");

            #endregion
        }

        #region Task2 
        static void SoyusSoyme(string[] cumle)
        {
            string[] arr = {"essek","badimcan","xiyar"};



            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < cumle.Length; j++)
                {
                    if (cumle[j].ToLower()==arr[i].ToLower())
                    {
                        cumle[j] = "Cammatin anasi bajsi var";
                    }
                    
                }
            }
            
            foreach (var item in cumle)
            {
                Console.WriteLine(item);
            }

        }
        #endregion
    }
}
