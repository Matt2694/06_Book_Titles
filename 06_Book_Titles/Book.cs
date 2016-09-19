
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace _06_Book_Titles
{

    internal class Book
    {
        internal string Titleized;
        public Book()
        {
            
        }
        public string Title
        {
            get
            {
                return Titleized;
            }
            internal set
            {
                Titleized = value;
                Titleized = Titleize();
            }
        }
        public string Titleize()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string[] cap;
            List<string> sreturn = new List<string>();
            char[] space = { ' ' };
            cap = Title.Split(space);
            string[] nonCap = { "and", "over", "the", "in", "of", "an", "a" };
            bool firstRun = true;
            int i = 0;
            foreach (string word in cap)
            {
                if (!Contains(word, nonCap) || firstRun)
                {
                    firstRun = false;
                    sreturn.Add(textInfo.ToTitleCase(word));
                    i++;
                }
                else
                {
                    sreturn.Add(word);
                    i++;
                }

            }
            string[] areturn = sreturn.ToArray();
            return string.Join(" ", areturn);
        }
        internal bool Contains(string v, string[] x)
        {
            bool result;
            int a = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (v == x[i])
                {
                    a++;
                }
            }
            if (a > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }


    }
}