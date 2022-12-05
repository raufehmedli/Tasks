//int[] numbers = new int[] { 7, 9, 12, 3, 11, 18 };

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] % 3 == 0) Console.WriteLine(numbers[i]);
//}
//task 1- Ədədlərdən ibarət array verilmişdir. Verilmiş ədədlər içərisində 3-ə bölünən ədədləri tapın.



//foreach (string name in names)
//{
//	for (int i = 0; i < name.Length; i++)
//	{
//		int letterCount = 0;
//		for (int j = 0; j < name.Length; j++)
//		{
//			if (name[i] == name[j])
//			{
//				letterCount++;
//			}
//		}
//		if (letterCount > 1)
//		{
//			Console.WriteLine(name);
//			break;
//		}
//	}
//}




//task 2- Verilmiş string array-ində hərf təkrarı olan string-ləri ekrana çıxarın. məs., Salam sözündə a təkrarlandığı üçün ekrana çıxarılacaq.




//int cem = 0;
//int[] numbers = new int[] { 7, 9, 12, 3, 11, 18 };
//foreach (int n in numbers)
//{
//    if (n % 2 == 0) cem += n;
//}
//Console.WriteLine(cem);


//int[] numbers = new int[] { 7, 9, 12, 3, 11, 18 };
//int cem = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//        cem += numbers[i];
//    {

//    }
//}
//Console.WriteLine(cem);



//task 3-Ədədlərdən ibarət array verilmişdir. Verilmiş ədədlər içərisində cüt ədədlərin cəmini tapın.



//int sozSayi(string str)
//{
//    int count = 1;
//    foreach (char ch in str)
//    {
//        if (ch == ' ') count++;
//    }
//    return count;
//}
//string sentence = Console.ReadLine();

//Console.WriteLine(sozSayi(sentence));



//task 4-Verilmiş string-in neçə sözdən ibarət olduğunu yoxlayan metod yazın.



//int[] numbers = new int[] { 7, 9, 12, 3, 11,18};

//void ikireqemli(int[] numbers)
//{
//	for (int i = 0; i < numbers.Length; i++)
//	{
//		if (numbers[i]>=10 && numbers[i]<100)
//		{
//			Console.WriteLine(numbers[i]);
//		}
//	}
//}
//ikireqemli(numbers);



//task 5- İkirəqəmli ədədləri ekrana çıxaran bir method yazın.




//int n = Convert.ToInt32(Console.ReadLine());
//int hasil = 1;

//for (int i = 1; i <= n; i++)
//{
//    hasil *= i;
//}
//Console.WriteLine(hasil);

//task 6-faktorial

//int n = Convert.ToInt32(Console.ReadLine());
//if (n>9 && n<100)
//{
//int a = n / 10;
//int b= n % 10;
//    Console.WriteLine(a+" "+b);
//}
//else
//{
//    Console.WriteLine("eded 2 reqemli deil");
//}

//task 7- 2reqemli ededlerin reqemlerin ayri ayri ver

//int number = int.Parse(Console.ReadLine());

//int sum = 0;

//while (number >= 1)
//{
//    sum += number % 10;
//    number /= 10;
//}
//Console.WriteLine(sum);

//reqemlerin cemi


//int index(str1, str2);
//string allstr(string last, string first);

//string str = "Hello World";
//int num = 0;

//while (str.IndexOf('o',num+1) !=-1)
//{
//    num=str.IndexOf('o',num+1);
//    Console.WriteLine(num);
//}

//string str1 = "Salam";
//int index = int.Parse(Console.ReadLine());
//int len = int.Parse(Console.ReadLine());
//void str(string str1, int index, int len)
//{
//    if (index+len>str1.Length)
//    {
//        len = str1.Length-index;
//    }

//    for (int i = index; i <index+len; i++)
//    {
//        Console.Write(str1[i]);

//    }
//}
//str(str1, index, len);

// task 8- incdexden baslasin verdiyinmiz lenge qeder hesablama


//int[] reqem = new int[] { 123, 456, 23, 487, 347 };


//void ucreqemli(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] >= 100 && arr[i] < 1000)
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}
//ucreqemli(reqem);

//task 9-3reqemli ededleri goster

//int m = int.Parse(Console.ReadLine());
//int i = 0;
//while (m%2==0)
//{
//    i++;
//    m /= 2;

//}
//Console.WriteLine(i);

//task 10-2e bolunsun ededlerin sayin


//    int[] reqem = new int[] { 5, 3, 2, 4 };
//int sum = 0;

//for (int i = 0; i < reqem.Length; i++)
//{
//    sum += reqem[i];
//}
//Console.WriteLine(sum);

//task 11-reqemlerin cemi


//int reqemcemi(int reqem)
//{
//    int cem = 0;
//    while (reqem > 0)
//    {
//        cem += reqem % 10;
//        reqem = reqem / 10;
//    }
//    return cem;
//}

//int[] cemi = new int[] { 45, 56, 98, 12, 22 };
//for (int i = 0; i < cemi.Length; i++)
//{
//    if (reqemcemi(cemi[i]) < 10)
//    {
//        Console.WriteLine(cemi[i]);
//    }

//}
//task 12-reqemlerin cemi 10dan kicik olanlari cixart;




//string removeChar( string str,char ch)
//{
//    string newStr = "";
//    foreach (char s in str)
//    {
//        if (s != ch)
//        {
//            newStr += s;
//        }
//    }
//    return newStr;
//}
//Console.WriteLine(removeChar("salam",'a'));
//task 13-sozdeki herfi silmek




//string mail = "rauf20032015@@gmail.com";

//bool IsValidEmail(string str)
//{
//    if (String.IsNullOrWhiteSpace(str)) return false;
//    if(!str.Contains('@')) return false;
//    string[] validStrings = {".az",".com",".net"};
//    foreach (string item in validStrings)
//    {
//        if (str.EndsWith(item)) return true;
//    }
//    return true;
//}
//Console.WriteLine(IsValidEmail(mail));
//task 14-email duzgunluyunu yoxlamaq


//string[] arr = new string[] { "salam", "ucbucaqli", "dordbucaqli" };
//foreach (string str in arr)
//{
//    if (str.Length >10)
//    {
//        Console.WriteLine(str);
//    }
//}

//task 15-Verilmiş string array-ində uzunluğu 10-dan çox olan sözləri ekrana çıxarın


//int a = int.Parse(Console.ReadLine());

//bool palindrom(int num)
//{
//    int son = num % 10;
//    int ilk = 0;
//    while (num >= 10)
//    {
//        num /= 10;
//    }
//    ilk += num;
//    if (son==ilk)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(palindrom(a));
// task 16-ədədin polindrom olub olmadığını yoxlayın. Məs, 252 polindromdur






//int[] status = new int[] {(int)HTTPStatus.OK, (int)HTTPStatus.Redirect, (int)HTTPStatus.NotFound,(int)HTTPStatus.ServerError };
//for (int i = 0; i < status.Length; i++)
//{
//    Console.WriteLine(status[i]);
//}

//enum HTTPStatus
//{
//OK = 200,
//Redirect = 302,
//NotFound = 404,
//ServerError = 500
//}

//task 17-Enum yaradın, adı olsun HTTPStatus. Bu enum-un aşağıdakı dəyərləri olacaq :
//1.OK - 200
//2.Redirect - 302
//3.NotFound - 404
//4.ServerError - 500

//Sizdən istədiyim sadəcə bunların integer dəyərini ekrana çıxarmaqdır


//int[] numbers = new int[5] { 10, 8, 7, 3, 14 };
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers[0]);

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }

//}
//foreach (int numb in numbers)
//{
//	Console.WriteLine(numb);
//}

//string str = "C# is programming language";

//foreach (char c in str)
//{
//	Console.Write(c);
//}


//int count = 0;
//foreach (char c in str)

//	if (c == 'a')
//	{
//		count++;
//	}

//for (int i = 0; i < str.Length; i++)
//{

//	if (str[i] == 'a')
//	{
//		count++;
//	}
//}
//Console.WriteLine(count);

//string ReverStr(string str1,string str2)
//{
//	string str = str2 + " " + str1;
//    string newStr = "";
//	for (int i = str.Length-1; i>=0; i--)
//	{
//		newStr += str[i];
//	}
//	return newStr;
//}
//Console.WriteLine(ReverStr("Salam" , "Dunya"));

//int n= Convert.ToInt32(Console.ReadLine());
//int hasil = 1;

//for (int i = 0; i <=n; i++)
//{
//	hasil *= i;
//	n++;
//}
//Console.WriteLine(hasil);


//int n = int.Parse(Console.ReadLine());
//int m = 0;
//int r;

//while (n > 0)
//{
//    r = n % 10;
//    m = m * 10 + r;
//    n /= 10;       //      n=n/10
//}
//Console.Write(m);
//int depth=int.Parse(Console.ReadLine());
//    int a = 0;
//    int b = 1;
//    int c;

//    for (int i = 0; i < depth; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;

//        Console.Write($"{c} ");
//    }
//    Console.WriteLine("\n");

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//if (c < a && c > b)
//{
//    Console.WriteLine("olar");
//}
//else
//{
//    Console.WriteLine("olmaz");
//}
