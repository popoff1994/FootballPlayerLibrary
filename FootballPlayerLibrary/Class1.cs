using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace FootballPlayerLibrary
{
    public class Class1
    {
        public int Id { get; set; }
        [MinLength(2, ErrorMessage = "Name must be at least to characters")]
        public string Name { get; set; }
        [Range(1, 120, ErrorMessage = "Age must be above 1, and below 120")]
        public int Age { get; set; }

        [Range(minimum: 1, maximum: 100, ErrorMessage = "Shirt number must be above 1, and below 99")]
        public int ShirtNumber { get; set; }

        public Class1(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public Class1()
        {
        }


        //Validates if the name is the correct length (at least 2 characters)
        public void NameValidatior() 
        {
            if (Name.Length < 2)
                throw new ArgumentException("NAME MUST BE AT LEAST TWO CHARACTERS LONG");           
            else
                Console.WriteLine("Name Validated");
        }
        //Validates if the Age is in the correct range(at least 1 year old, and less then 120 years old)
        public void AgeValidator()
        {
            if (Age <= 1 || Age >= 120)
                throw new ArgumentOutOfRangeException("AGE MUST BE ABOVE 1, AND BELOW 120!");
            else
                Console.WriteLine("Age Validated");
        }
        //Validates the shirt number (must be possitve and below 99)
        public void ShirtNumberValidator()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
                throw new ArgumentOutOfRangeException("SHIRT NUMBER HAS TO BE BETWEEN 1 AND 99!");
            else
                Console.WriteLine("Shirt number Validated");


        }
        
       
   
    }
}

