using System;
namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Строка1";
            string str2 = new string('s', 5);      
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            str1 = str2;
            Console.WriteLine(str1);
            if (str1 == str2) { Console.WriteLine("Good"); }
            if (str3 != str2) { Console.WriteLine("No Good"); }
            string str4 = "Строка4";
            str4 = str4 + str2;
            Console.WriteLine(str4);
            Console.WriteLine(str4[0]);
            string str5 = "ssssss/*Комментарий*/";
            System.Text.StringBuilder str6 = new System.Text.StringBuilder(100);
            int i = 0;
            int j = 0;
            for (i = 0; i < str5.Length; i++)
            {
                if (str5[i] == '/' && str5[i + 1] == '*')
                {
                    i += 2;
                    while (!(str5[i] == '*' && str5[i + 1] == '/'))
                    {
                        str6.Insert(j, str5[i]);
                        j++;
                        i++;
                    }
                    break;
                }
                else { i++; }
            }
            string res = str6.ToString();
            Console.WriteLine(res);

            string str7 = "sыыыыыststudentКомментарий*/";
            System.Text.StringBuilder str8 = new System.Text.StringBuilder(100);
            i = 0;
            j = 0;
            for (i = 0; i < str5.Length; i++)
            {
                if (!(str7[i] == 's' && str7[i + 1] == 't' && str7[i + 2] == 'u' && str7[i + 3] == 'd' && str7[i + 4] == 'e' && str7[i + 5] == 'n' && str7[i + 6] == 't'))
                {
                    while (!(str7[i] == 's' && str7[i + 1] == 't' && str7[i + 2] == 'u' && str7[i + 3] == 'd' && str7[i + 4] == 'e' && str7[i + 5] == 'n' && str7[i + 6] == 't'))
                    {
                        str8.Insert(j, str7[i]);
                        j++;

                        break;
                    }
                }
                else { break; }

            }

            string res2 = str8.ToString();
            Console.WriteLine(res2);
            // второе задание
            SumInWords(2001);
            // третье задание
            SplitJoin();
            // четвертое и пятое задание
            ExampleStringBuilder();
            // шестое задание 
            CharArray();
        }
        public static void SumInWords(int param)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(200);
            int first = param / 1000 - 1;
            int second = param / 100 % 10 - 1;
            int third = param / 10 % 10 - 1;
            int fourth = param % 10 - 1;
            int last = param % 100;
            Console.WriteLine(first);
            string[] ar1 = {"один ", "два ",
                            "три", "четыре", "пять",
                            "шесть", "семь", "восемь",
                            "девять"};
            string[] ar2 = {"десять", "двадцать",
                            "тридцать", "сорок", "пятьдесят",
                            "шестьдесят", "семьдесят", "восемьдесят",
                            "девяносто"};
            string[] ar3 = {"сто", "двести",
                            "триста", "четыреста", "пятьсот",
                            "шестьсот", "семьсот", "восемьсот",
                            "девятьсот"};
            string[] ar4 = {"одна тысяча", "две тысячи",
                            "три тысячи", "четыре тысячи", "пять тысяч",
                            "шесть тысяч", "семь тысяч", "восемь тысяч",
                            "девять тысяч"};
            string[] ar5 = {"одиннадцать", "двенадцать",
                            "тринадцать", "четырнадцать", "пятнадцать",
                            "шестнадцать", "семнадцать", "восемнадцать",
                            "девятнадцать"};
            if (last > 10 && last < 20)
            {
                ar2 = ar5;
                third = last % 10 - 1;
                fourth = -1;
            }

            string res = temp.ToString();

            if (first >= 0) { res = ar4[first] + ' '; }
            if (second >= 0) { res += ar3[second] + ' '; }
            if (third >= 0) { res += ar2[third] + ' '; }
            if (fourth >= 0)
            {
                res += ar1[fourth] + ' ';
                switch (fourth)
                {
                    case 0:
                        res += "рубль";
                        break;
                    case 1:
                        res += "рубля";
                        break;
                    case 2:
                        res += "рубля";
                        break;
                    case 3:
                        res += "рубля";
                        break;
                    default:
                        res += "рублей";
                        break;
                }

            }
            else { res += "рублей"; }
            Console.WriteLine(res);
        }
        public static void SplitJoin()
        {

            string text1 = "Большой серый котенок с серой, грудкой блаженно, зажмурился.";
            string[] SimpleSentences;
            string[] Word;
            SimpleSentences = text1.Split(',');
            foreach (var word1 in SimpleSentences)
            {
                Console.Write($"<{word1}> ");
            }
            Console.WriteLine();
            Word = text1.Split(' ');
            foreach (var word2 in Word)
            {
                Console.WriteLine($"<{word2}>");
            }
            Console.WriteLine(String.Join(' ', Word));

        }
        public static void ExampleStringBuilder()
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder(100);
            System.Text.StringBuilder text = new System.Text.StringBuilder("String – example of StringBuilder");
            str.Insert(0, '2');
            str.Insert(1, '0'); // дописываю в конец
            string res = str.ToString();
            Console.WriteLine(res);
            string str1 = "Строка1";
            str1 += " Строка2"; // продолжаю строку
            Console.WriteLine(str1);
            System.Text.StringBuilder str2 = new System.Text.StringBuilder(100);
            System.Text.StringBuilder str3 = new System.Text.StringBuilder(100);
            str2.Insert(0, '2');
            str2.Insert(1, '0');
            str3.Insert(0, '2');
            str3.Insert(1, '0');
            str2.Append(str3);
            string res2 = str2.ToString();
            Console.WriteLine(res2);

            foreach (var word1 in res)
            {
                str3.AppendFormat(" {0}: {1} ", word1, res);

            }
            Console.WriteLine(str3.ToString());
            // пятое задание
            // Console.WriteLine(str1.Capacity);
            Console.WriteLine("значение для обычного {0}", str2.Capacity); // 100 для stringbuilder
            Console.WriteLine("значение для составного {0}", text.Capacity); // 33 для текста
            Console.WriteLine("максимум для обычного {0}", str2.MaxCapacity);
            Console.WriteLine("максимум для составного {0}", text.MaxCapacity);
            text.EnsureCapacity(200);
            str2.EnsureCapacity(200);
            Console.WriteLine("значение для обычного {0}", str2.Capacity); // меньше нельзя
            Console.WriteLine("значение для составного {0}", text.Capacity);
        }
        public static void CharArray()
        {
             //char[] str1 = "Hello, World!";
            char[] str1 = { '1' };
            string str2 = "Здравствуй, Мир!";
            string str3 = "";
            char[] str4 = { '6', '1', '2', '3', '5' };
            // создание символов
            for (var i = 0; i < str2.Length; i++)
            {
                Console.Write("{0}", str2[i]);
            }
            Console.WriteLine();
            // создание строки
            for (var j = 0; j < str1.Length; j++)
            {
                str3 += str1[j];
            }
            Console.WriteLine(str3);
            // вхождение символа 
            for (var i = 0; i < str2.Length; i++)
            {
                if (str2[i] == 'З')
                {
                    Console.WriteLine("вхождение символа: {0}", i);
                    break;
                }
            }
            string str5 = "Мир";
            int start = 0;
            int end = str2.Length;
            int count = 0;
            int at = 0;
            int flag = 0;
            str2.IndexOf(str5);
            while ((start <= end) && (at > -1))
            {
                count = end - start;
                at = str2.IndexOf(str5, start, count);
                if (at == -1) break;
                Console.Write("{0} ", at);
                if (at != 0) 
                flag = 1;
                if (flag == 1) break;
                start = at + 1;
            }
        }

    }
}

