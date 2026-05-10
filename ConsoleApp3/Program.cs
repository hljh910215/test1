namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public interface IValidator
    { 
        bool IsValid(string fullName);
    }
    public class FileSizeValidator 
    {
        
    }
    public class FileExValidator { 

    }
    public class ImageValidator { 
    
    }
    public class FileHelper {
        public bool IsValid(string fullName, IValidator[] validators)
        {
            foreach (var validator in validators)
            {
                if (!validator.IsValid(fullName))
                {
                    return false;
                }
            }
        }
    }
}
