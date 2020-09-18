using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractyStudent
{
    abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name + LastName);
        }
    }
    class Student : Person
    {
        public static int size = 1;
        Student[] data;
        public int Zacet { get; set; }
        public int Cours { get; set; }  
        public Student() { data = new Student[size]; }
        public Student(string name, string lastName, int zacet, int cours)
            : base(name, lastName)
        {
            data = new Student[size];
        }
        public Student this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"имя фамилия студента:\t{Name} {LastName}\n" +
                $"номер зачетной книжки:\t{Zacet}\n" +
                $"курс обучения:\t{Cours}");            
        }        
    }
    class Aspirant:Person
    {
        public static int size=1;
        public int Cours { get; set; }
        public int Zachet { get; set; }
        public string Theme { get; set; }
        Aspirant[] data;
        public Aspirant()
        {
           data = new Aspirant[size];
        }
        public Aspirant(string name,string lastName,int cours,int zacet,string theme)
            :base(name,lastName)
        {
            data = new Aspirant[size];
        }
        public Aspirant this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"имя фамилия:\t {Name} {LastName}\n" +
                $"номер зачётной книжки:\t {Zachet}\n" +
                $"курс обучения:\t {Cours}\n" +
                $"тема диссертации:\t{Theme}");
        }
    }
}
