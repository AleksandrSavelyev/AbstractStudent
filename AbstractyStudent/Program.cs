using System;

namespace AbstractyStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int stuCount = 0;
            Aspirant asp = new Aspirant();
            int aspCount = 0;
            for(; ; )
            {
                Console.WriteLine("введите 1 чтобы добавить студента\n" +
                    "введите 2 чтобы добавить аспиранта\n" +
                    "введите 3чтобы узнать информацию о студентах\n" +
                    "введите 4 чтобы узнать информацию о аспирантах");
                switch(Console.ReadLine())
                {
                    case "1":AddStudent(stu, stuCount);
                        stuCount += 1;
                        break;
                    case "2":AddAspirant(asp, aspCount);
                        aspCount++;
                        break;
                    case "3":InfoStudent(stu,stuCount);
                        break;
                    case "4":InfoAspirant(asp, aspCount);
                        break;
                    default:
                        break;
                }
            }
        }

        static void AddStudent(Student stu,int i)
        {
            stu[i] = new Student();
            Student.size += 1;
            Console.WriteLine("введите имя студента");
            stu[i].Name = NameValid();
            Console.WriteLine("введите фамилию студента");
            stu[i].LastName = NameValid();
            Console.WriteLine("введите курс обучения");
            stu[i].Cours = CoursValid();
            Console.WriteLine("введите номер зачетной книжки");
            stu[i].Zacet = ZacetValid();            
        }
        static void AddAspirant(Aspirant asp,int i)
        {
            asp[i] = new Aspirant();
            Console.WriteLine("введите имя аспиранта");
            asp[i].Name = NameValid();
            Console.WriteLine("введите фамилию аспиранта");
            asp[i].LastName = NameValid();
            Console.WriteLine("ввендите курс обучения");
            asp[i].Cours = CoursValid();
            Console.WriteLine("введите номер зачетной книжки");
            asp[i].Zachet = ZacetValid();
            Console.WriteLine("введите тему диссертации");
            asp[i].Theme = Console.ReadLine();
        }
        static string NameValid()
        {
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] big_rus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Э', 'Ю', 'Я' };
            
            string name = Console.ReadLine();
            char first = name[0];
            int j = 0;
            for (int i = 0; i < big_eng.Length; i++)
            {
                if (first == big_eng[i])
                {
                    j++;
                    break;
                }
            }            
            if (j == 0)
            {
                for (int i = 0; i < big_rus.Length; i++)
                {
                    if (first == big_rus[i])
                    {
                        j++;
                        break;
                    }
                }
            }           
            if (j == 0)
            {
                Console.WriteLine("введите коректные данные");
                NameValid();
            }
            else// j=1;
            {
                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < eng.Length; i++)
                    {
                        if (name[k] == eng[i])
                        {
                            j++;
                            break;
                        }
                    }
                }
                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < rus.Length; i++)
                    {
                        if (name[k] == rus[i])
                        {
                            j++;

                            break;
                        }
                    }
                }
            }
            if (j != name.Length)
            {
                Console.WriteLine("введите коректные данные");
                NameValid();
            }
            return name;
        }
        static int NumValid()
        {
            if (int.TryParse(Console.ReadLine(), out int a))
                return a;
            else
            {
                Console.WriteLine("введите коректные данные");
                return NumValid();
            }
        }
        static int CoursValid()
        {
            int cours = NumValid();
            if (cours >= 1 & cours <= 10)
                return cours;
            else
            {
                Console.WriteLine("введите курс обучения коректно");
                return CoursValid();
            }
        }
        static int ZacetValid()
        {
            int zacet = NumValid();
            if (zacet >= 10000000 & zacet <= 99999999)
                return zacet;
            Console.WriteLine("номер зачетной книжки состоит из 8символов");
            return ZacetValid();
        }
        static void InfoStudent(Student stu,int TotStu)
        {
            Console.WriteLine($"всего зарегестрираванно {TotStu} студентов");
            Console.WriteLine("введите номер студента");
            int i = InfoValid(TotStu);
            Student inf = stu[i];
            inf.PrintInfo();
        }
        static void InfoAspirant(Aspirant asp,int totAsp)
        {
            Console.WriteLine($"всего зарегестрированно {totAsp} аспирантов");
            Console.WriteLine("введите номер аспиранта");
            int i = InfoValid(totAsp);
            asp[i].PrintInfo();
        }
        static int InfoValid(int i)
        {            
            int num = NumValid();
            if (num >=1&&num<=i)
                return i - 1;
            Console.WriteLine("студента с таким номером не существует");
            return InfoValid(i);
        }
    }
}

