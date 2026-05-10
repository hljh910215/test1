using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeeHandler h1 = new HandlerA(); //70歲以上男性 處理器
            FeeHandler h2 = new HandlerB(); //60歲以上女性 處理器
            FeeHandler h3 = new HandlerC(); //3歲以上小孩

            h1.Next = h2; //將處理器鏈接成鏈表
            h2.Next = h3;
            var custmer = new Customer(true,2);
            int fee = h1.GetFee(custmer);
            Console.WriteLine(fee);

        }
    }
    class Customer
    {
        public Customer(bool gender, int age)
        {
            Gender = gender;
            Age = age;
        }
        public bool Gender { get; set;} //性別
        public int Age { get; set; }//年齡


    }

    abstract class FeeHandler {
        public FeeHandler Next { get; set; }

        public int GetFee(Customer customer)
        {
            if(CanHandle(customer))
            {
                return CalculateFee(customer);
            }
            if (Next != null)
            { 
                return Next.GetFee(customer);
            }
            return 15;
        }
        public abstract bool CanHandle(Customer customer);
        public abstract int CalculateFee(Customer customer);
    }
    //70歲以上男性 處理器
    class HandlerA : FeeHandler
    {
        public override int CalculateFee(Customer customer) 
        {
            return 2;
        }

        public override bool CanHandle(Customer customer)
        {
            return customer.Gender == true && customer.Age >= 70; //客戶如果是70歲男性就回傳值
        }
    }
    //60歲以上女性 處理器
    class HandlerB : FeeHandler{
        public override int CalculateFee(Customer customer)
        {
            return 3;
        }

        public override bool CanHandle(Customer customer)
        {
            return customer.Gender == true && customer.Age >= 60;//客戶如果是60歲女性就回傳值
        }
    }
    //3歲以下小孩 處理器
    class HandlerC : FeeHandler
    {
        public override int CalculateFee(Customer customer)
        {
            return 0;
        }

        public override bool CanHandle(Customer customer)
        {
            return customer.Age <= 3;//客戶如果是3歲小孩以下就回傳值
        }
    }
}
