namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reqemler icerisinde cut ededleri cixart

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var query = from number in numbers
            //            where number%2==0
            //            select number;
            //foreach(var x in query)
            //{
            //    Console.WriteLine(x);
            //}

            // reqemler icerisinde tek ededleri ve 11den kicik olanlari cixart

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15 };

            //var query = from number in numbers
            //            where number > 0 && number < 11
            //            where number % 2 == 1
            //            select number;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            // ededin kvadratini tap ve 20den boyukdurse ededi ve kvadratini yaz

            int[] numbers = new int[] { 2, 3, 5, 6, 8, 9, 10 };

            var query = from number in numbers
                        let num=number*number
                        where num>20
                        select new { number, num };

            foreach(var x in query)
            {
                Console.WriteLine(x);
            }
        }
    }
}