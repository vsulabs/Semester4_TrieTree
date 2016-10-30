using System;
using System.Linq;
using System.Windows.Forms;

namespace TrieTree
{
    /// <summary>
    /// класс-наследние от TrieTree - адаптирован для GUI приложений
    /// каждый экземпляр класса: 
    /// -связан с текстовым полем на форме, 
    /// -знает имя файла, откуда загружены или куда сохранены данные,
    /// -запоминает собственное состояние: были ли модификации данных
    /// </summary>
    class GuiTrieTree: TrieTree
    {
        #region fields and properties

        private readonly TextBox _tbTree;                           // поле на форме 
        private bool _modified;                                     // были ли изменения
        private string _fileName;                                   // имя файла 
        public bool Modified => _modified;                          // доступ к информации об изменениях: только для чтения
        private bool Mod { set { _modified = value; Show(); } }     // в случае, если произошли изменения, запоминаем их и отображаем на форму
        public string FileName => _fileName;                        // доступ к информации о имени файла: только для чтения
        
        #endregion
        
        /// <summary>
        /// конструктор, позволяющий связать экземпляр класса текстовым полем на форме
        /// </summary>
        /// <param name="textBox">текстовое поле на форма</param>
        public GuiTrieTree(TextBox textBox) {
            _tbTree = textBox;
            _tbTree.Clear();
            _fileName = string.Empty;
            _modified = false;
        } // constructor GUITrieTree

        /// <summary>
        /// конструктор, производящий загрузку данных из файла с указанным именем
        /// </summary>
        /// <param name="textBox">текстовое поле на форме</param>
        /// <param name="name">имя файла, из которого должна происходить загрузка данных</param>
        public GuiTrieTree(TextBox textBox, string name) {
            _tbTree = textBox;
            _fileName = name;
            _modified = false;
            if (!base.LoadFromFile(_fileName))
                throw new TypeLoadException("ошибка при загрузке данных");
            Show();
        } // constructor GUITrieTree
        
        /// <summary>
        /// Добавляет слово в дерево, обновляя текстовое поле на форме
        /// </summary>
        /// <param name="wrd">добавляемое слово</param>
        public new bool Add(string wrd) {
            if (base.Add(wrd)) {
                Mod = true;
                return true;
            }
            return false;
        } // ...new Add
        /// <summary>
        /// Добавляет слово в дерево, обновляя текстовое поле на форме
        /// </summary>
        public new void Clear() {
            if (!IsEmpty()) {
                base.Clear();
                Mod = true;
            }
        } // ...new Clear
        /// <summary>
        /// удаляет слово в структуре Trie дерева, обновляя текстовое поле на форме
        /// </summary>
        /// <param name="wrd">удаляемое слово</param>
        /// <returns>true, если удаление прошло успешно </returns>
        public new bool Delete(string wrd) {
            if (base.Delete(wrd)) {
                Mod = true;
                return true;
            }
            return false;
        } // ...new Delete
        /// <summary>
        /// Отображает информацию на текстовом поле, связанным с экземпляром trie-дерева
        /// </summary>
        /// <returns></returns>
        public new void Show() {        
            _tbTree.Lines = base.Show().ToArray<string>();        
        } // ...new Show

        /// <summary>
        /// Сохраняет данные в файл с указанным именем
        /// </summary>
        /// <param name="name">Имя файла, в который следует произвести сохранение данных</param>
        public new void SaveToFile(string name) {            
            _fileName = name;
            base.SaveToFile(_fileName);
            _modified = false;
        } // ...new SaveToFile
                  
        /// <summary>
        /// метод позволяет загрузить данные из файла с указанным именем.
        /// </summary>
        /// <param name="name">имя файла.</param>
        /// <returns>true, если добавление прошло успешно, false в противном случае </returns>
        public new bool LoadFromFile(string name) {
            _fileName = name;
            bool res = base.LoadFromFile(_fileName);
            Mod = false;
            //Mod = modified || !res;
            return res;
        } // ...LoadFromFile
    } // class GUIrieTree
}
