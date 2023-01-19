using Console_Jgsp.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Jgsp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Dodaj fakultet.");
            Console.Write("Unesi ime fakulteta: ");
            string imeFakulteta = Console.ReadLine();
            Fakultet fakultet = new Fakultet(imeFakulteta);

            Console.WriteLine("---------------");
            Console.WriteLine("Kreirani fakultet je: " + fakultet.VratiImeFakulteta() + " osnovan " + fakultet.GodinaOsnivanja + " godine.\nDa li zelite da promenite ime fakulteta?\n1. da\n2. ne");
            int rezultat = int.Parse(Console.ReadLine());
            if (rezultat == 1)
            {
                Console.Write("Unesite novo ime fakulteta: ");
                fakultet.PromeniImeFakulteta(Console.ReadLine());
            }

            Console.WriteLine("---------------");




            Console.WriteLine("Dodaj studenta");
            Console.Write("Unesi ime studenta: ");
            string imeStudenta = Console.ReadLine();
            Console.Write("Unesi prezime studenta: ");
            string prezimeStudenta = Console.ReadLine();
            Console.Write("Unesi godiste studenta: ");
            int godisteStudenta = int.Parse(Console.ReadLine());
            Console.Write("Unesi godinu studija: ");
            int godinaStudija = int.Parse(Console.ReadLine());
            Student student = new Student(imeStudenta, prezimeStudenta, godisteStudenta, fakultet, godinaStudija);

            Console.WriteLine("---------------");

            Console.WriteLine("Dodaj profesora");
            Console.Write("Unesi ime profesora: ");
            string imeProfesora = Console.ReadLine();
            Console.Write("Unesi prezime profesora: ");
            string prezimeProfesora = Console.ReadLine();
            Console.Write("Unesi godiste profesora: ");
            int godisteProfesora = int.Parse(Console.ReadLine());
            Console.Write("Unesi godine staza: ");
            int godineStaza = int.Parse(Console.ReadLine());
            Profesor profesor = new Profesor(imeProfesora, prezimeProfesora, godisteProfesora);
            profesor.Fakultet = fakultet;
            profesor.GodineStaza = godineStaza;


            Console.WriteLine("---------------");

            Console.WriteLine("Ispis:");

            Console.WriteLine("Student - Ime i Prezime: " + student.VratiImeIPrezime() + " ,Godiste: " + student.Godiste + " ,Fakultet:" + student.Fakultet.VratiImeFakulteta());
            Console.WriteLine("Profesor - Ime i Prezime: " + profesor.VratiImeIPrezime() + " ,Godiste: " + profesor.Godiste + " ,Fakultet na kom je zaposlen:" + profesor.Fakultet.VratiImeFakulteta());



        }
    }
}
