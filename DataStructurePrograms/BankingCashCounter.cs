using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class BankingCashCounter<T>
    {
        QueueOperations<T> queue = new QueueOperations<T>();
        private int bankBalance = 1000000;

        public void CashCounter()
        {
            Console.Write("How Many People Came To The Bank Today: ");
            int peopleCount = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < peopleCount; i++)
            {
                Console.Write("Give Person Name: ");
                T name = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                queue.Enqueue(name);
            }
            Console.Write("Persons In The Queue: ");
            queue.Display();

            for (int i = 0; i < peopleCount; i++)
            {
                BankTransactions(queue.head.data);
                Console.Write("Persons Remaining In The Queue: ");
                queue.Display();
            }
        }

        public void BankTransactions(T person)
        {
            Console.Write("\n\nWelcome To Bank..\n\n" +
                "Bank Transactions:\n" +
                "1. Deposit\n" +
                "2. WithDraw\n" +
                "Please Select Your Transaction Type: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    while (true)
                    {
                        Console.Write("Enter the Amount To Deposit: ");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                        if (deposite < 50000)
                        {
                            bankBalance += deposite;
                            Console.WriteLine("\nReceipt Of Transaction:\n" +
                                "Customer Name: " + queue.head.data + "\n" +
                                "Transaction Type: Deposit\n" +
                                "Amount: " + deposite + "\n" +
                                "Transaction Completed..\n");
                            queue.Dequeue();
                            break;
                        }
                        else
                            Console.WriteLine("\nDeposit Limit is <50000 For Once..Please Enter Amount With-In the Limit..");
                    }
                    break;
                case 2:
                    while (true)
                    {
                        Console.Write("Enter the Amount To WithDraw: ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw < 20000)
                        {
                            bankBalance -= withdraw;
                            Console.WriteLine("\nReceipt Of Transaction:\n" +
                                "Customer Name: " + queue.head.data + "\n" +
                                "Transaction Type: Withdraw\n" +
                                "Amount: " + withdraw + "\n" +
                                "Transaction Completed..\n");
                            queue.Dequeue();
                            break;
                        }
                        else
                            Console.WriteLine("\nWithDraw Limit is <20000 For Once..Please Enter Amount With-In the Limit..");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid Transaction Type..Please Select Correct Transaction Type..");
                    break;
            }
        }
    }
}
