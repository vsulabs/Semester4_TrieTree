using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

/*
    В trie-дереве найти все слова, которые содержат только символы из указанного множества 
*/
namespace TrieTree
{
    public partial class FrmMain : Form
    {
        GuiTrieTree _guiTrieTree; // структура, хранящая данные в программе       

        /// <summary> конструктор формы. Выполняется:
        /// -инициализация компонентов на форме, 
        /// -задание фильтров для диалогов открытия и сохраниния
        /// -делегирование контроля над доступом и видимостью элементов управления стандартному инструменту Application.Idle
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            saveFileD.Filter = @"Text files (*.txt) | *.txt";
            saveFileD.FileName = "";
            saveFileD.Title = @"Save As...";
            saveFileD.InitialDirectory = Directory.GetCurrentDirectory();
            openFileD.Filter = @"Text files (*.txt) | *.txt";
            openFileD.FileName = "";
            openFileD.Title = @"Open file ...";
            openFileD.InitialDirectory = Directory.GetCurrentDirectory();

            Application.Idle += VisibleElems;
        } // конструктор        

        /// <summary> Действие показывает условие поставленной задачи 
        /// текст появляется в новом окне MessageBox
        /// </summary>
        private void tsmCondition_Click(object sender, EventArgs e)  {
            MessageBox.Show(@"В trie-дереве найти все слова, которые содержат только символы из указанного множества ");
        } // условие выполняемой задачи

        /// <summary> Действие открывает диалоговое окно, в котором можно выбрать файл для загрузки данных.
        /// В случае завершения операции данные будут загружены. При некорректной загрузке структура останется пуста</summary>
        private void tsmOpen_Click(object sender, EventArgs e) {
            if (openFileD.ShowDialog() == DialogResult.OK) {
                if (CanClose(_guiTrieTree, sender, e)) {
                    _guiTrieTree = new GuiTrieTree(tbInput);
                    if (!_guiTrieTree.LoadFromFile(openFileD.FileName)) {
                        _guiTrieTree = null;
                        MessageBox.Show(@"Данные не смогли быть загружены");
                    }
                }
            } 
        } // открытие файла для загрузки данных

        /// <summary> действие закрывает программу, завершая ее работу 
        /// перед закрытием происходит проверка, сохранены ли данные</summary>
        private void tsmExit_Click(object sender, EventArgs e) {
            Close();
        } // завершение работы программы

        /// <summary>действие создает новое Trie-дерево
        /// при этом происходит проверка, были ли сохранены последние изменения,
        /// а также очищаются текстовые поля формы</summary>
        private void tsmNew_Click(object sender, EventArgs e) {
            if (CanClose(_guiTrieTree, sender, e))
                _guiTrieTree = new GuiTrieTree(tbInput);         
        } // новое trie дерево

        /// <summary>Действие открывает диалоговое окно в котором можно выбрать, как сохранить данные
        /// Если данные уже были сохранены в каком-то файле или загружены из файла, 
        /// данные сохранятся в прежнем месте</summary>
        private void tsmSave_Click(object sender, EventArgs e) {
            if (_guiTrieTree.FileName == string.Empty)
                tsmSaveAs_Click(sender, e);
            else
                _guiTrieTree.SaveToFile(_guiTrieTree.FileName);
        } // сохранение дерева

        /// диалоговое окно "сохранить как". Узнается путь для сохраниения
        /// при этом структура данных будет связана новым файлом,
        /// что отразится на последующих вызовах диалога save
        private void tsmSaveAs_Click(object sender, EventArgs e) {
            saveFileD.FileName = _guiTrieTree.FileName;
            if (saveFileD.ShowDialog() == DialogResult.OK)
                _guiTrieTree.SaveToFile(saveFileD.FileName);
        } // SaveAs
 
        /// <summary>закрыть дерево, с которым происходит работы. 
        /// В случае несохраненных изменений появляется диалоговое окно,
        /// позволяющее сохранить данные в файл </summary>
        private void tsmClose_Click(object sender, EventArgs e) {
            if (CanClose(_guiTrieTree, sender, e)) // проверка, были ли изменения и диалог о необходимости их сохранения
                _guiTrieTree = null;
        } // прекращение работы со структурой данных, форма в исходном состоянии
               
        /// <summary> Добавление слова в хранимую структуру.
        /// Слово получено после ввода в текстовое поле нового окна.
        /// Строка проходит проверку и в случае корректности добавляется в структуру
        /// </summary>
        private void tsmAdd_Click(object sender, EventArgs e) {
            FrmInputWord input = new FrmInputWord("Введите слово для добавления:");
            if (input.ShowDialog() == DialogResult.OK)
                if (!_guiTrieTree.Add(input.InputText))
                    MessageBox.Show(@"Данные не были добавлены");
        } // добавление слова в Trie дерево
        
        /// <summary> Поиск слова в хранимой структуре данных.
        /// Слово получено из окна ввода данных, проходит проверку.
        /// Затем, по результату проверки, появляется окно с информацией о результате
        /// </summary>
        private void tsmSearch_Click(object sender, EventArgs e) {
            FrmInputWord input = new FrmInputWord("Введите слово, которое требуется найти:");
            if (input.ShowDialog() == DialogResult.OK) {
                string tmp = input.InputText;
                if (!_guiTrieTree.Find(input.InputText))
                    tmp += " не";
                MessageBox.Show(@"слово " + tmp + @" надено");
            }
        } // поиск слова в дереве

        /// <summary> удаление слова из структуры данных
        /// Диалоговое окно позволяет ввести слово, подлежащее удалению.
        /// После проверки корректности введенной строки происходит попытка удаление
        /// </summary>
        private void tsmDelete_Click(object sender, EventArgs e) {
            FrmInputWord input = new FrmInputWord("Введите слово, которое требуется удалить:");
            if (input.ShowDialog() == DialogResult.OK)
                if (!_guiTrieTree.Delete(input.InputText))
                    MessageBox.Show(@"Не удалось удалить слово " + input.InputText);
        } // удаление слова из структуры данных

        /// <summary> Очистка данных структуры.
        /// Происходит после подтверждения пользователем в диалоговом окне, тк
        /// действие невозможно отменить
        /// </summary>
        private void tsmClear_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(@"Вы уверены, что хотите удалить данные?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) // проверка результата диалогового окна 
                _guiTrieTree.Clear();
        } // удаление данных из структуры трай дерева

        /// <summary> Действие запускает выполнение основной программы: 
        /// поиск слов, содержащих только символы из заданного множества
        /// символы будут получены из вспомогательной формы в виде строки
        /// в случае некорректности символов, функция завершит работу, 
        /// изменения не будут внесены
        /// </summary>
        private void tsmRun_Click(object sender, EventArgs e) {
            FrmInputWord input = new FrmInputWord("Введите символы, которые должны содержаться в искомых словах: ");
            
            if (input.ShowDialog() == DialogResult.OK) {
                tbOutput.Lines = _guiTrieTree.ShowBySet(input.InputText).ToArray<string>();
                tbOutput.Show();   
            }
            
        } // Run

        /// <summary> очистка текстового поля с результатом работы программы
        /// перед очисткой появляется диалоговое окно с предложением сохранить данные в текстовый файл
        /// </summary>
        private void tsmClearResult_Click(object sender, EventArgs e) {
            if (tbOutput.Lines.Length != 0) { // имеет смысл, если данные вообще существуют
                DialogResult dialogResult = MessageBox.Show(@"Хотите ли вы сохранить данные в файл?", "", MessageBoxButtons.YesNo);
                // проверка результата диалогового окна подтверждения сохранения данных перед закрытием
                if (dialogResult == DialogResult.Yes) 
                    tsmSaveResult_Click(sender, e);
                tbOutput.Clear();
                
                // в случае отмены все остается без изменений
            } // if (поле не пусто)
        } // очистка поля результата

        /// <summary> сохранение полученного в результате работы программы набора слов
        /// Если таких слов не существует, диалоговое окно ошибки
        /// иначе диалоговое окно с выбором пути для сохранения
        /// </summary>
        private void tsmSaveResult_Click(object sender, EventArgs e) {
            if (saveFileD.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = new StreamWriter(Name);
                for (int i = 0; i < tbOutput.Lines.Length; i++)
                    sw.WriteLine(tbOutput.Lines[i]);
                sw.Close();
            }
        } // сохранение результата
               
        /// <summary> функция проверяет, были ли модифицированы данные в структуре данных.
        /// Если данные были изменены, появляется диалоговое окно, в котором можно 
        /// подтвердить сохранение данных
        /// </summary>        
        private bool CanClose(GuiTrieTree tree, object sender, EventArgs e) {
            if (tree != null && tree.Modified) {
                DialogResult dl = MessageBox.Show(@"Хотите ли вы сохранить данные в файл?", @"Внимание", MessageBoxButtons.YesNoCancel);
                if (dl == DialogResult.Yes) {
                    tsmSave_Click(sender, e);
                    return !tree.Modified;
                }
                if (dl == DialogResult.No)
                    return true;
                return false;
            }
            return true;
        } // ...CanClose

        /// <summary> в зависимости от состояния хранимой структуры регулирует
        /// видимость или доступность элементов управления формы
        /// </summary>
        private void VisibleElems(object sender, EventArgs e) {
            tbInput.Visible = tbOutput.Visible = _guiTrieTree != null;
            tsmClearResult.Enabled = tsmSaveResult.Enabled = tbOutput.Lines.Length > 0;

            tsmAdd.Enabled = tsBtnAdd.Enabled = _guiTrieTree != null;
            tsmSearch.Enabled = tsBtnSearch.Enabled = 
                tsmDelete.Enabled = tsBtnDelete.Enabled = 
                tsmRun.Enabled = tsBtnRun.Enabled = 
                tsmClear.Enabled = (_guiTrieTree != null && !_guiTrieTree.IsEmpty());

            tsmSave.Enabled = tsBtnSave.Enabled = 
                tsmSaveAs.Enabled = tsmClose.Enabled = 
                tsBtnClose.Enabled = (_guiTrieTree != null);
        } // ... VisibleElems

        /// <summary> событие при попытке закрыть форму без сохранения данных:
        /// появится диалоговое окно с предложением сохранить изменения в файл
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
             e.Cancel = !CanClose(_guiTrieTree, sender, e);
        } // событие при закрытии формы

        /// <summary> При изменении данных в стуктуре, меняется и поле исходных данных.
        /// Автоматически происходит и очистка поля результата, тк он уже может не соответствовать 
        /// исходным данным
        /// </summary>
        private void tbInput_TextChanged(object sender, EventArgs e) {
            tbOutput.Clear();
        } 

    } // class frmMain
}
