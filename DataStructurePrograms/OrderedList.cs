using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructurePrograms
{
    public class OrderedList<T> where T : IComparable
    {
        UnOrderedList<T> list = new UnOrderedList<T>();
        public void OrderedListOperation()
        {
            string text = File.ReadAllText(@"D:\BridgeLabz Problems Git Hub Local Repository\DataStructurePrograms\DataStructurePrograms\OrderedFile.txt");
            string[] fileList = text.Split(" ");
            List<T> files = new List<T>();
            foreach (string word in fileList)
            {
                T element = (T)Convert.ChangeType(word, typeof(T));
                files.Add(element);
            }

            foreach (var num in files)
            {
                list.Insert(num);
            }
            Console.Write("\nThe content in the list is:");
            list.Display();

            Console.Write("\n\nEnter the word need to be searched in file: ");
            int Word = Convert.ToInt32(Console.ReadLine());
            T searchWord = (T)Convert.ChangeType(Word, typeof(T));

            //search word in linked list 
            if (list.Search(searchWord))
            {
                list.Delete(searchWord);
            }
            else
            {
                list.Insert(searchWord);
            }

            Console.Write("\nThe content in the list is: ");
            list.Display();
            Console.Write("\n\nThe File after Ordered: ");
            list.Sort();
            list.Display();

            //write contents from linked list to file
            string resultText = list.ReturnString();
            File.WriteAllText(@"D:\BridgeLabz Problems Git Hub Local Repository\DataStructurePrograms\DataStructurePrograms\OrderedFile.txt", resultText);
            Console.WriteLine("\n\nFile Updated Successfully!!!!!! ");
        }
    }
}
