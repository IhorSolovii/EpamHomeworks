using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    class Task3
    {
        List<string> myList = new List<string>();
        Random rndm = new Random();
        public Task3()
        {
            for (int i = 0; i < 100; i++)
            {
                myList.Add(RandomStringGenerating());
            }
            int countBefore = myList.Count;
            Console.WriteLine($"Before transformations: {countBefore}");
            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList.Count; j++)
                {
                    if (i == j) { continue; }
                    if (myList[i] == myList[j])
                    {
                        myList.Remove(myList[j]);
                    }
                }
            }
            char[] firstSymb;
            for (int j = 0; j < myList.Count; j++)
            {
                firstSymb = myList[j].ToCharArray();
                if (firstSymb[0] == 'Z')
                {
                    myList.Remove(myList[j]);
                }
            }
            int countAfter = myList.Count;
            Console.WriteLine($"After transformations: {countAfter}");
            bool asc = true;
            while (asc)
            {
                asc = false;
                for (int i = 0; i < myList.Count - 1; ++i)
                    if (myList[i].CompareTo(myList[i + 1]) > 0)
                    {
                        string lett = myList[i];
                        myList[i] = myList[i + 1];
                        myList[i + 1] = lett;
                        asc = true;
                    }
            }
        }
        public string RandomStringGenerating()
        {
            char[] wrandom = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'X', 'W', 'Y', 'Z' };
            string randomString = "";
            for (int i = 0; i < 4; i++)
            {
                randomString += wrandom[rndm.Next(0, 24)].ToString();
            }
            return randomString;
        }
        public void Show()
        {
            foreach (string s in myList)
                Console.WriteLine(s);
        }
        public void DisplayPage(int numberOfPage)
        {
            for (int i = (numberOfPage - 1) * 5; i < (numberOfPage - 1) * 5 + 5; i++)
                Console.WriteLine(myList[i]);
        }
    }
}
