using System;
namespace ConsoleApp
{
    class BasicInformationProgram
    {
        static void Main(string[] args)
        { 
            Console.Write("name: ");
            string name = Console.ReadLine();
            
            Console.Write("Present Address: ");
            string PresentAddress = Console.ReadLine();
            
            Console.Write("Permanent Address: ");
            string PermanentAddress = Console.ReadLine();
            
            Console.Write("Date Of Birth: ");
            string DateOfBirth = Console.ReadLine();
            
            Console.Write("Civil Status: ");
            string CivilStatus = Console.ReadLine();
             
            Console.Write("Citizenship: ");
            string Citizenship = Console.ReadLine();
            
            Console.Write("Place Of Birth: ");
            string PlaceOfBirth = Console.ReadLine();
            
            Console.Write("Name Of Father: ");
            string NameOfFather = Console.ReadLine();

            Console.Write("Name Of Mother: ");
            string NameOfMother = Console.ReadLine();
            
            Console.Write("Address: ");
            string Address = Console.ReadLine();
            
            Console.Write("Language Or DialectSpoken: ");
            string LanguageOrDialectSpoken = Console.ReadLine();
            
            Console.Write("Person To Be Notified In Case Of Emengency: ");
            string PersonToBeNotifiedInCaseOfEmengency = Console.ReadLine();
            
            Console.Write("Religion:");
            string Religion = Console.ReadLine();
            
            Console.Write("age: ");
            string age = Console.ReadLine();
            
            Console.Write("Weight: ");
            string weight = Console.ReadLine();
            
            Console.Write("Height: ");
            string height = Console.ReadLine();
            
            Console.WriteLine("\nName              /" + name );
        Console.WriteLine("Present Address   /" + PresentAddress );
        Console.WriteLine("Permanent Address /" + PermanentAddress );
        Console.WriteLine("Date of Birth     /" + DateOfBirth + "                    Religion:"+Religion )    ;
        Console.WriteLine("Civil Status      /" + CivilStatus+"                            Age:" +age);
        Console.WriteLine("Citizenship       /" + Citizenship +"                            Weight:" +weight);
        Console.WriteLine("Place of Birth    /" + PlaceOfBirth +"                     Height:"+height);
        Console.WriteLine("Name of Father    /" + NameOfFather );
        Console.WriteLine("Name of Mother    /" + NameOfMother );
        Console.WriteLine("Address           /" + Address );
        Console.WriteLine("Languages or Dialecs Spoken /" + LanguageOrDialectSpoken );
        Console.WriteLine("Person to be notified In Case of Emergency /" + PersonToBeNotifiedInCaseOfEmengency );
            
        }
    }
}
