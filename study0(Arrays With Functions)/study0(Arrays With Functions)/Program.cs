namespace study0_Arrays_With_Functions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1:Kullanıcıdan isim, soyisim ve yaş biglsini alıp yanyana yazdıran methodu yazınız.(Yaş int olacak) (isim, soyisim, yaş bilgileri Main methodunda istenecek )
            //string name, surname;
            //int age;
            //Console.Write("Adınızı Giriniz: ");
            //name = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz: ");
            //surname = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz: ");
            //bool ageIsInt = int.TryParse(Console.ReadLine(), out age);
            //if (ageIsInt)
            //{
            //    WriteInformation(name, surname, age);
            //}
            //else Console.WriteLine("!!Lutfen Bir Integer Deger Giriniz!!");
            #endregion
            #region Question2:10 tane random sayıyı ekrana yazan methodu yazınız.
            //int[] realRandomNumber = new int[10];
            //int[] resultNumber = GenerateRandomNumber(realRandomNumber);
            //WriteRandomNumber(resultNumber);
            #endregion
            #region Question3:Kullanıcıdan iki kenar değerini alıp dikdörtgenin alanını yazdıran methodu ve çevresini hesaplayıp, sonucu dönen methodu yazın. (iki kenar değeri Main methodunda istenecek)(İki tane method yazılacak. 1.Method alanını yazdıracak. 2.Method Çevresini hesaplayacak)
            //int longEdge, shortEdge, perimeter;
            //Console.Write("Dikdörtgenin Uzun Kenarının Degerini Giriniz: ");
            //longEdge = int.Parse(Console.ReadLine());
            //Console.Write("Dikdörtgenin Kısa Kenarının Degerini Giriniz: ");
            //shortEdge = int.Parse(Console.ReadLine());
            //CalculateWriteArea(longEdge, shortEdge);
            //perimeter = CalculatePerimeter(longEdge, shortEdge);
            //Console.WriteLine($"Dikdörtgenin Cevresi: {perimeter}");
            #endregion
            #region Question4:Bir string array alıp elemanlarını tek bir string yapıp döndüren methodu yazınız.(string[] sarki = { "Oynama", "şıkıdım", "şıkıdım!" };)
            //string[] music = { "Oynama", "şıkıdım", "şıkıdım!" };
            //string word = CombineArray(music);
            //WriteWord(word);
            #endregion

            #region Question5:Bir int array'i alıp eleman değerlerinin ortalamasını ekrana yazan metodu yazınız.(int[] sayilar = { 4, 45, 32, 85, 25, 89, 65, 102, 43 };)
            //int[] number = { 4, 45, 32, 85, 25, 89, 65, 102, 43 };
            //double averageValue = CalculateArray(number);
            //Write(averageValue);
            #endregion

            #region Question6:Bir int arrayi alıp eleman değerlerini toplayıp, toplamı dönen methodu yazınız.
            //Random rnd = new Random();
            //int number = rnd.Next(1, 10);
            //int[] randomNumber = new int[number];
            //randomNumber = MakeRandomArray(randomNumber);
            //int result = SumArrayNumber(randomNumber);
            //Write(result);
            #endregion


        }
        #region Solution for A Question1
        //static void WriteInformation(string tempName, string tempSurname, int tempAge)
        //{
        //    Console.WriteLine($"Kisisel Bilgileriniz: {tempName} {tempSurname} {tempAge}");
        //} 
        #endregion

        #region Solution for A Question2
        //static int[] GenerateRandomNumber(int[] tempNumber)
        //{
        //    for (int i = 0; i < tempNumber.Length; i++)
        //    {
        //        Random rnd = new Random();
        //        tempNumber[i] = rnd.Next(1, 51);
        //    }
        //    return tempNumber;
        //}

        //static void WriteRandomNumber(int[] tempNumber)
        //{
        //    foreach (int i in tempNumber)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region Solution for A Question3
        //static void CalculateWriteArea(int edge1, int edge2)
        //{
        //    int totalArea = edge1 * edge2;
        //    Console.WriteLine($"Dikdörtgenin Alani: {totalArea}");
        //}
        //static int CalculatePerimeter(int edge1, int edge2)
        //{
        //    return  (2 * (edge1 + edge2));
        //}
        #endregion

        #region Solution for A Question4
        //static string CombineArray(string[] array)
        //{
        //    string tempWord = "";
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        tempWord += array[i]; 
        //    }
        //    return tempWord;
        //}
        #endregion

        #region Solution for A Question5
        //static double CalculateArray(int[] tempNumber)
        //{
        //    double total = 0;
        //    for (int i = 0; i < tempNumber.Length; i++)
        //    {
        //        total += tempNumber[i];
        //    }
        //    return (total / tempNumber.Length);
        //}

        //static void Write(double temp)
        //{
        //    Console.WriteLine($"Arrayin Icerisindeki Degerlerin Ortalaması: {temp}");
        //}
        #endregion

        #region Solution for A Question6

        //static int[] MakeRandomArray(int[] array)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = rnd.Next(1, 20);
        //    }
        //    return array;
        //}
        //static int SumArrayNumber(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}
        //static void Write(int value)
        //{
        //    Console.WriteLine($"Toplama Isleminin Sonucu: {value}");
        //}
        #endregion
    }
}
