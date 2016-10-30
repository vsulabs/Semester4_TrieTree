using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TrieTree
{
    /// <summary>
    /// класс Trie-Tree: содержит корень дерева и вызывает все рекурсивные методы для работы с ним
    /// определены:     конструкторы без параметров TrieTree()
    /// методы: Clear, Add, AddIter, Find, FindIter, Delete, LoadFromFile, SaveToFile, Show, ShowBySet, WordsFromRange
    /// статические методы: CheckWord, WordToSet
    /// </summary>
    class TrieTree
    {
        TrieNode _root; // корень Trie-дерева

        public TrieTree() {
            _root = null;
        } // конструктор
        /// <summary>
        /// очистка списка: корень устанавливается в null-значение
        /// </summary>
        public void Clear() {
            _root = null;
        } // ...Clear

        /// <summary>
        /// Добавляет слово в Trie дерево, если его ещё не было и оно удовлетворяет языку структуры
        /// </summary>
        /// <param name="wrd">добавляемое слово</param>
        /// <returns>true, если добавление прошло успешно 
        /// (слова ещё не было в структуре и оно корректно)</returns>
        public bool Add(string wrd) {
            if (!CheckWord(wrd))
                return false;
            if (_root == null)
                _root = new TrieNode();
            return _root.Add(ref wrd);
        } // add
        /// <summary>
        /// поиск слова в структуре Trie-дерева.
        /// </summary>
        /// <param name="wrd">искомое слово</param>
        /// <returns>TRUE, если слово найдено, FALSE в противном случае</returns>
        public bool Find(string wrd) {
            if (_root == null || !CheckWord(wrd))
                return false; 
            return _root.Find(wrd);
        } // ...Find
        /// <summary>
        /// удаление слова из структуры данных
        /// </summary>
        /// <param name="wrd">удаляемое слово</param>
        /// <returns>TRUE, если слово удалено, FALSE в противном случае</returns>
        public bool Delete(string wrd) {
            if (_root == null || !CheckWord(wrd)) 
                return false;
            if (_root.Delete(wrd)) {
                if (_root.IsEmpty())
                    _root = null;
                return true;
            } // if (удаление прошло успешно)
            return false;
        } // ...delete

        /// <summary>
        /// загрузка словаря (списка слов) из файла в структуру
        /// будет осуществлена проверка загружаемых слов, в случае
        /// некорректных данных дерево останется пустым
        /// </summary>
        /// <param name="filename">имя файла, откуда будет происходить загрузка</param>
        /// <returns>true, если загрузка прошла успешно</returns>
        public bool LoadFromFile(string filename) {
            StreamReader sr = new StreamReader(filename, Encoding.GetEncoding(1251));
            _root = new TrieNode();

            string tmp;
            bool res = true;

            // пока не закончился файл и загруженные данные корректны
            while (sr.Peek() >= 0 && res) {
                tmp = sr.ReadLine()?.ToLower().Trim();
                res = CheckWord(tmp);
                if (res)
                    res = _root.Add(ref tmp);                
            } // while...

            if (!res)
                Clear();
            sr.Close();
            return res;
        } // LoadFromFile
        /// <summary>
        /// метод сохранения данных из экземпляра Trie-дерева в файл
        /// </summary>
        /// <param name="filename">имя файла, в который будет произведено сохранение</param>
        public void SaveToFile(string filename) {
            StreamWriter sw = new StreamWriter(filename);
            if (_root == null || _root.IsEmpty()) {
                sw.Close();
                return;
            }

            List<string> sl = Show();
            for (int i = 0; i < sl.Count; i++)
                sw.WriteLine(sl[i]);
            sw.Close();
        } // ...SaveToFile
        /// <summary>
        /// Проверка, пусто ли дерево
        /// </summary>
        /// <returns>true, если дерево пусто, false в противном случае</returns>
        public bool IsEmpty() {
            return _root == null; //if (root == null) return true; return root.isEmpty();
        } // ...isEmpty

        /// <summary>
        /// Ищет в текущем дереве все слова и сохраняет их в виде списка
        /// </summary>
        /// <returns>список всех слов данного Trie дерева</returns>
        public List<string> Show() {
            List<string> res = new List<string>();
            if (_root == null)
                return res;

            _root.Show(res);
            return res;
        } // ...Show
        /// <summary>
        /// метод позволяет получить список, состоящий из слов, содержащих только определенный набор символов из заданного множества
        /// </summary>
        /// <param name="wordSet">строка, содержащая символы множества</param>
        /// <returns>список слов, состоящих только из символов заданного множества</returns>
        public List<string> ShowBySet(string wordSet) {
            List<string> res = new List<string>();
            if (_root == null || !CheckWord(wordSet))
                return res;

            HashSet<char> set = new HashSet<char>(wordSet);
            _root.ShowSet(set, res);
            return res;
        } // ...ShowBySet        
        /// <summary>
        /// статический метод: позволяет узнать, соответствует ли строка языку данной структуры, т. е. содержит ли корректные символы
        /// </summary>
        /// <param name="wrd">проверяемое на корректность слово</param>
        /// <returns>true, если слово удовлетворяет условиям, false в противном случае</returns>
        public static bool CheckWord(string wrd) {
            if (wrd == string.Empty)
                return false;
            wrd = wrd.ToLower(); 
            for (int i = 0; i < wrd.Length; i++)
                if (wrd[i] < (char)TrieNode.FirstLitera || wrd[i] > (char)TrieNode.LastLitera)
                    return false;
            return true;
        } // ...CheckWord
       
    } // class TrieTree
}