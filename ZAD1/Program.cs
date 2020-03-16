using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lista = new List<Student>();

            Console.WriteLine("Podaj sciezke do pliku CSV!");
            var plikCSV = Console.ReadLine();
            
            Console.WriteLine("Adres sciezki docelowej:");
            var docelowa = Console.ReadLine();

            using (StreamReader sr = new StreamReader(new File(plikCSV).OpenRead())
            {
                string line = null;
                    while((line=sr.ReadLine) != null){
                        string [] studentL = line.Split(',');
                        var st = new Student(studentL[0],studentL[1],studentL[2],studentL[3],studentL[4],studentL[5],studentL[6],studentL[7],studentL[8]);
                        lista.add(st);
                    }
            }
            
		FileStream writer = new FileStream(docelowa, FileMode.Create);
		XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
		serializer.Serialize(writer, list);
           
        }
    }

}

    

namespace Student
{
    


public class Student{

        string imie;
        string nazwisko;
        string kierunek;
        string tryb;
        string id;
        string data;
        string mail;
        string imieM;
        string imieO;

    public Student(string imie, string nazwisko, string kierunek, string tryb, string id, string data, string mail, string imieM, string imieO)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.kierunek = kierunek;
        this.tryb = tryb;
        this.id = id;
        this.data = data;
        this.mail = mail;
        this.imieM = imieM;
        this.imieO = imieO;
    }
}
}
