using System;

 namespace Unit_Testing
{
    public class Program
    {
        static public decimal Balance = 1000;

        public static void Main(string[] args)
        {
              ATM();
        
                

          
        }
        public static void ATM()
        {
            bool y = true;
            while (y == true)
            {
                //welcomenig 
                Console.WriteLine("WELCOME TO Waseem BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4 or any number. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                int choice = int.Parse(Console.ReadLine());
          
                switch (choice)
                {
                    
                    case 1:
                        Console.WriteLine(ViewBalance());
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        decimal val = int.Parse(Console.ReadLine());
                        Withdraw(val);
                        Console.WriteLine("***************\n\n");
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        decimal val2 = int.Parse(Console.ReadLine());
                        Deposit(val2);
                        Console.WriteLine("***************\n\n");
                        break;
                    default:
                        Console.WriteLine("\n\n THANKS FOR USING YES ATM SERVICE");
                        y = false;
                        Console.WriteLine("***************\n\n");
                        break;

                }
                
            }
        }
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal val)
        {
            if (val > Balance && val < 0)
            {
             
                return Balance;

            }
            else if ( val < 0)
            {
           Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                return Balance;

            }
            else
            {
                Balance = Balance - val;

            }

            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", Balance);
            return Balance;
        }
        
        public static decimal  Deposit(decimal val)
        {
          

            if (val < 0)
            {
                Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");

                return (Balance);

            }
            else
            { Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
               

                Balance = Balance + val; 
            }
            Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", Balance);
            return Balance;
        }

    }
}
