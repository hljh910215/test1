namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Len Chen";
            UserName userName = UserNameFactory.Create(input);
            Console.WriteLine($"姓:{userName.LastName},名:{userName.FirstName}");

            input = "Wang,Simon";
            userName = UserNameFactory.Create(input);
            Console.WriteLine($"姓:{userName.LastName},名:{userName.FirstName}");
        }
    }
    class UserNameFactory
    {
        public static UserName Create(string fullName)
        {
            if (fullName.Contains(","))
            {
                return new LastNameLast(fullName);
            }
            else
            {
                return new FirstNameFirst(fullName);
            }
        }
    }
     
        
    
    class UserName
    { 
        public string FirstName { get; set; } //名
        public string LastName { get; set; }  //姓  
    }

    class FirstNameFirst : UserName {
        public FirstNameFirst(string fullName)
        { 
            var parts = fullName.Split(' ');
            FirstName = parts[0].Trim();
            LastName = parts[1].Trim();
        }
    }


    class LastNameLast : UserName {
        public LastNameLast(string fullName)
        {
            var parts = fullName.Split(',');
            FirstName = parts[0].Trim();
            LastName = parts[1].Trim();
        }
    }

}
