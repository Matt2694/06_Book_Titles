namespace _06_Book_Titles{

    internal class Book{

        internal string Titleized;
        public string Title{

            get{
                return Titleized;
            }
            internal set{
                Titleized = value;
                Titleized = Titleize();
            }
        }
        public string Titleize(){

            string[] cap;
            string finalWord = "";
            cap = Title.Split(' ');
            string[] nonCap = { "and", "over", "the", "in", "of", "an", "a" };
            bool firstRun = true;
            foreach (string word in cap){
                if (!Contains(word, nonCap) || firstRun){
                    firstRun = false;
                    char firstLetter = word[0];
                    string restWord = word.Substring(1);
                    finalWord += char.ToUpper(firstLetter) + restWord + " ";
                }
                else{
                    finalWord += word + " ";
                }

            }
            return finalWord.Trim(' ');
        }
        internal bool Contains(string v, string[] x){

            bool result;
            int a = 0;
            for (int i = 0; i < x.Length; i++){
                if (v == x[i]){
                    a++;
                }
            }
            if (a > 0){
                result = true;
            }
            else{
                result = false;
            }
            return result;
        }


    }
}