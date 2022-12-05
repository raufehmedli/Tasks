namespace StringMEthod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "My Name is Rauf";

            Console.WriteLine(text.Length);//uzunlugu gosterir
            Console.WriteLine(text.ToLower());//butun herfleri balaca edir
            Console.WriteLine(text.ToUpper());//butun herfleri boyudur
            Console.WriteLine(text.Trim());//kenarlardaa bosluq varsa onlari silir
            Console.WriteLine(text.Trim('M'));//eger char verersek sonda ve evvelde olan bu chari silir ancaq char tiipinde deyer vermek olur
            Console.WriteLine(text.TrimStart());//cumlenin ve ya sozun evvelinde bosluq varsa silir
            Console.WriteLine(text.TrimEnd());//cumlenin ve ya sozun sonunda bosluq varsa silir
            Console.WriteLine(text.Split()[0]);//cumledeki sozleri bosluq ifadesine gore ayirir ve arraylere cevirir ve indeksle istediyimiz sozu getire bilirik
            Console.WriteLine(text.StartsWith("My"));//cumlenin sozle ve ya herfle baslayib baslamadigin yoxlayir true false qaytarir
            Console.WriteLine(text.EndsWith("Rauf"));//cumlenin sozle ve ya herfle bitdiyin yoxlayir true false qaytarir
            Console.WriteLine(text.Contains("Name"));//Cumlede soz ve ya herfin olub olmadigin yoxlamaq ucundu true false qaytarir
            Console.WriteLine(text.IndexOf("is"));//cumle ve ya herfin hansi indexden basladigin gosterir
            Console.WriteLine(text.Substring(5));//5-ci indexden baslayir ve qqalan butun sozleri ve herfleri cixardir
            Console.WriteLine(text.Substring(5,4));//5-ci indexden baslayir ve 5ci index daxil olmaqla soraki 4dene indeksi cixardir yeni 5den 9e qeder 9daxil deil
            int index = text.IndexOf("Name");
            Console.WriteLine(text.Substring(index));//index int tipi oldugu ucun verdiyim sozden qalan sozleri cixartdi
            Console.WriteLine(text.Replace(' ','-'));//cumledeki sozu ve ya herifi istediyimiz soz ve ya herfle deyisdirmek ucun istifade olunur
            Console.WriteLine(text.Insert(0,"info"));//index-e cumle ve ya soz elave etmek ucundur 
            Console.WriteLine(text.Insert(text.Length,"...")); //biz eger sonuna elave etmek istiyirkse bu cur yaziriq

        }
    }
}