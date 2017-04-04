using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vCardLib;
using vCardLib.Collections;
using vCardLib.Deserializers;
using vCardLib.Helpers;
using vCardLib.Serializers;

namespace VCF_Manipulator
{
    class Program
    {
        const string SRC = @"C:\Users\dkaschel\Downloads\contacts.vcf";
        const string DEST = "dest.vcf";
        static void Main(string[] args)
        {
            //vCardCollection src = Deserializer.FromFile(SRC);
            var collection = (from vCard v in Deserializer.FromFile(SRC)
                              select v).ToList();
            var result = collection.FirstOrDefault(v => v.GivenName == "Blake");

            //This all works just fine, but at this point I realized that VCF's don't actually contain ALL of google's
            //contact info, just some of it. Damn. Back to square 1.

            Console.WriteLine("test");
        }
    }
}
