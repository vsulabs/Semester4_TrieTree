using System.Collections.Generic;
/*
    В trie-дереве найти все слова, которые содержат только символы из указанного множества 
*/
namespace TrieTree
{    
    /// <summary>
    /// Класс TrieNode определяет узел trie-дерева: его свойства и поведение
    /// объявленные следующие 
    /// методы:         isEmpty, Add, Find, Delete, Show, ShowSet
    /// конструкторы:   TrieNode() - без параметров
    /// свойства:       Point {g, s }; 
    /// </summary>
    class TrieNode
    {
        #region fields and const

        public const int LastLitera = 'z';                                  // определяет первое число диапазона букв
        public const int FirstLitera = 'a';                                 // последнее число диапазона букв
        public const int Range = LastLitera - FirstLitera + 1;              // диапазон
        
        public bool Point { get; set; }                                     // признак конца слова
        readonly TrieNode[] _next;                                          // ссылки на следующие буквы

        #endregion

        /// <summary> индексатор для обращения к следующей букве слова (следующему звену)
        /// </summary>
        /// <param name="i">индекс, который следует поставить в соответствие букве алфавита</param>
        /// <returns>следующий узел trie-дерева</returns>
        public TrieNode this[int i] {                           
            get { return _next[i]; }
            set { _next[i] = value; }
        } // индексатор для обращения к следующей букве слова, хранящегося в Trie дереве
        
        /// <summary> конструктор по умолчанию: все ссылки в null, узел не является завершением слова (Point = false)
        /// </summary>
        public TrieNode() {
            _next = new TrieNode[Range];
            for (int i = 0; i < Range; i++)
                _next[i] = null;
            Point = false;
        } // ...constructor TreeNode
        
        /// <summary> проверка, пуст ли список
        /// </summary>
        /// <returns>TRUE, если пуст, FALSE в противном случае</returns>
        public bool IsEmpty() {
            if (Point)
                return false;
            for (int i = 0; i < Range ; i++)
               if (_next[i] != null) 
                   return false;
            return true;
        } // ...isEmpty

        /// <summary>
        /// добавляет слово в структуру
        /// </summary>
        /// <param name="wrd">Добавляемое слово</param>
        /// <returns>TRUE, если добавление прошло успешно, FALSE в противном случае</returns>
        public bool Add(ref string wrd) {
            if (wrd.Equals(string.Empty)) {
                bool res = !Point; // если такое слово уже есть, возвращаем false. 
                Point = true;
                return res; // True только в случае, если такого слова не было
            } 
            int first = GetIndex(wrd[0]);
            wrd = wrd.Remove(0, 1);
            if (_next[first] == null)
                _next[first] = new TrieNode();
            return _next[first].Add(ref wrd);
        } // ...Add
        /// <summary>
        /// Поиск слова в структуре TrieTree
        /// </summary>
        /// <param name="wrd">Искомое слово</param>
        /// <returns>возвращает TRUE, если слово найдено, false в противном случае</returns>
        public bool Find(string wrd) {
            if (wrd == string.Empty) // если слово закончилось, то проверяем, является ли узел точкой
                return Point;
            if (_next[GetIndex(wrd[0])] == null)
                return false;
            return _next[GetIndex(wrd[0])].Find(wrd.Remove(0, 1));
        } // ...Find
        /// <summary>
        /// удаляет указанное слово в структуре данных TrieTree
        /// </summary>
        /// <param name="wrd">удаляемое слово</param>
        /// <returns>true, если слово было удалено, false в противном случае</returns>
        public bool Delete(string wrd) {
            // если слово закончилось, проверяем, есть ли в этом узле точка
            if (wrd == string.Empty) {
                bool res = Point;
                Point = false;
                return res;
            } 
            if (_next[GetIndex(wrd[0])] != null) 
                if (_next[GetIndex(wrd[0])].Delete(wrd.Remove(0, 1))) {
                    if (_next[GetIndex(wrd[0])].IsEmpty())
                        _next[GetIndex(wrd[0])] = null;
                    return true;
                } // if (рекурсивное удаление прошло успешно) ...

            return false; 
        } // ...Delete

        /// <summary>
        /// Поиск всех слов в структуре
        /// Извне функцию следует вызывать без явной подстановки строки (оставить параметр по умолчанию).
        /// </summary>
        /// <param name="sl">результирующий список слов</param>
        /// <param name="wrd">накапливает слово. При вызове следует оставить значение по умлочанию</param>
        public void Show(List<string> sl, string wrd = "")
        {
            if (Point)
                sl.Add(wrd);
            for (int i = 0; i < Range; i++)
                if (_next[i] != null)
                    _next[i].Show(sl, wrd + GetSymb(i));
        } // ...Show
        /// <summary>
        /// Поиск слов, содержащих только символы из указанного множества
        /// </summary>
        /// <param name="set">множество символов</param>
        /// <param name="sl">результирующий список слов</param>
        /// <param name="wrd">параметр, накапливающий слово в рекурсии. При вызове оставить пустым</param>
        public void ShowSet(HashSet<char> set, List<string> sl, string wrd = "")
        {
            if (Point) 
                sl.Add(wrd);
            for (int i = 0; i < Range; i++)
                if (_next[i] != null && set.Contains(GetSymb(i)))
                    _next[i].ShowSet(set, sl, wrd + GetSymb(i));
        } // ...ShowSet
        /// <summary>
        /// функция возвращает код символа, переданного в качестве параметра. 
        /// Диапазон [от 0 до количества символов в алфавите] для корректного обращения к массиву
        /// тогда поправка выглядит следующим образом: код переданной буквы минус код первой буквы алфавита
        /// </summary>
        /// <param name="chr">буква, код которой следует определить</param>
        /// <returns>код-позиция символа в массиве, индексами которого служат символы алфавита</returns>
        private static int GetIndex(char chr)       { return chr - FirstLitera; }      // GetIndex
        /// <summary>
        /// функция возвращает символ из алфавита, соответствующий номеру ячейки массива
        /// </summary>
        /// <param name="i">номер ячейки массива</param>
        /// <returns>символ алфавита, поставленный в соответствие номеру ячейки</returns>
        private static char GetSymb(int i)          { return (char)(i + FirstLitera); }     // GetSybm
    } // ...class TreeNode

}
