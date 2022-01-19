// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace dictionaryAssgn
{
    public class PrimeMinister 
    {
        string PrimeMinisterName;
        int PrimeMinisterYear;

        public string Name
        {
            get { return PrimeMinisterName; }
            set { PrimeMinisterName = value; }
        }
        public int Year
        {
            get { return PrimeMinisterYear; }
            set { PrimeMinisterYear = value; }
        }
        public override string ToString()
        {
            return "Prime Minister Name: " + Name + " & " + "Year:" + Year;
        }
        public PrimeMinister(string name,int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
     class Program
    {
        static Dictionary<string, PrimeMinister> obj = new Dictionary<string, PrimeMinister>();
        static void Main(string[] args)
        {
            DictionaryInit();

            Console.WriteLine("1.");
            foreach (var primeMini in obj.Values)
            {
                if(primeMini.Year.Equals(2004))
                {
                    Console.WriteLine(primeMini);
                }
            }

            Console.WriteLine("\n2.After Adding Current Prime Minister:");
            obj["forth"] = new PrimeMinister("Narendra Modi",2014);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);

            Console.WriteLine("\n3.Sorted by year:-");
            obj = obj.OrderBy(r => r.Value.Year).ToDictionary(r => r.Key, r => r.Value);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);

        }

        private static void DictionaryInit()
        {
            obj.Add("First", new PrimeMinister("Atal Bihari Vajpayee", 1998));
            obj.Add("second", new PrimeMinister("Narendra Modi", 2014));
            obj.Add("third", new PrimeMinister("Manmohan Singh", 2004));
        }
    }
}
