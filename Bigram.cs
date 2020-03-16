using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bigram
{
    public partial class Bigram : Form
    {
        BiCoeff coeffTable = new BiCoeff() { new BiCoeffLine() { BiCoeff = new List<int>() {2, 7, 8, 6, 7, 7, 7, 7, 4, 7, 7, 7, 8, 8, 3, 7, 6, 7, 8, 2, 6, 6, 7, 7, 5, 5, 0, 0, 0, 0, 6, 7, 9} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {7, 1, 1, 0, 1, 6, 2, 2, 6, 0, 5, 6, 3, 5, 7, 2, 7, 5, 0, 7, 0, 5, 4, 1, 0, 5, 5, 7, 2, 2, 0, 3, 5} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 0, 5, 0, 4, 8, 0, 3, 7, 1, 6, 7, 5, 6, 8, 4, 6, 6, 6, 6, 0, 3, 0, 1, 3, 0, 0, 8, 2, 0, 0, 4, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 0, 1, 1, 6, 5, 0, 0, 6, 0, 4, 5, 4, 4, 8, 0, 7, 0, 0, 6, 0, 0, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 4} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 1, 6, 3, 4, 8, 1, 0, 7, 0, 4, 7, 1, 7, 8, 4, 6, 5, 2, 7, 1, 3, 3, 3, 4, 0, 0, 6, 4, 0, 4, 5, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {5, 5, 6, 7, 8, 6, 6, 6, 4, 7, 7, 8, 8, 9, 6, 5, 8, 8, 9, 3, 3, 6, 5, 6, 5, 6, 0, 0, 1, 1, 5, 5, 9} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 0, 0, 0, 6, 7, 2, 1, 7, 0, 5, 0, 2, 7, 1, 0, 1, 2, 1, 3, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 2} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 4, 6, 2, 6, 4, 1, 1, 6, 1, 5, 5, 6, 6, 7, 1, 5, 0, 0, 6, 0, 0, 2, 1, 0, 0, 2, 6, 2, 0, 0, 4, 6} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 6, 7, 6, 6, 8, 5, 7, 7, 7, 7, 6, 8, 8, 5, 5, 7, 8, 8, 1, 5, 7, 7, 7, 6, 3, 0, 1, 0, 0, 6, 7, 9} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 0, 3, 0, 3, 0, 0, 0, 0, 0, 3, 6, 5, 4, 0, 0, 0, 6, 6, 0, 0, 0, 1, 2, 3, 0, 0, 0, 0, 0, 0, 0, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 1, 5, 1, 1, 6, 5, 2, 7, 1, 2, 7, 0, 5, 8, 0, 7, 6, 6, 7, 0, 0, 6, 0, 1, 0, 0, 0, 0, 0, 0, 0, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 4, 1, 2, 1, 8, 6, 1, 8, 0, 4, 4, 1, 6, 7, 0, 0, 3, 3, 6, 3, 0, 0, 3, 1, 1, 0, 6, 8, 0, 7, 8, 6} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {7, 5, 7, 2, 2, 8, 0, 1, 7, 0, 4, 4, 7, 6, 8, 5, 1, 3, 1, 6, 1, 0, 0, 0, 0, 0, 0, 7, 3, 0, 0, 6, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {9, 0, 3, 3, 6, 8, 1, 1, 9, 0, 6, 0, 1, 7, 8, 0, 0, 5, 7, 6, 5, 2, 5, 3, 0, 0, 0, 8, 5, 0, 4, 6, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {2, 8, 8, 8, 8, 6, 7, 7, 6, 8, 7, 8, 8, 7, 6, 7, 8, 8, 8, 3, 2, 5, 6, 7, 6, 5, 0, 0, 1, 5, 2, 5, 9} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {7, 0, 0, 0, 0, 8, 0, 4, 7, 0, 3, 6, 1, 4, 8, 4, 9, 4, 5, 6, 2, 0, 1, 0, 0, 0, 0, 4, 5, 3, 0, 4, 4} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {9, 1, 6, 4, 4, 8, 6, 0, 8, 0, 5, 2, 6, 6, 8, 4, 2, 6, 6, 7, 3, 5, 4, 2, 4, 2, 0, 7, 4, 0, 1, 6, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 4, 6, 2, 5, 7, 2, 0, 7, 0, 7, 8, 6, 6, 8, 7, 5, 6, 9, 6, 3, 5, 1, 5, 5, 0, 0, 5, 6, 1, 3, 8, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {8, 2, 7, 1, 4, 8, 0, 0, 8, 0, 6, 4, 5, 6, 9, 3, 8, 8, 4, 6, 0, 0, 0, 4, 0, 2, 1, 7, 8, 0, 1, 5, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {3, 4, 4, 6, 6, 7, 6, 5, 3, 3, 6, 5, 5, 6, 0, 6, 7, 7, 7, 1, 5, 5, 0, 6, 3, 6, 0, 0, 0, 0, 7, 4, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 0, 0, 0, 0, 5, 0, 0, 6, 0, 0, 2, 2, 0, 6, 0, 4, 0, 3, 5, 4, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {4, 3, 3, 0, 0, 4, 0, 0, 3, 0, 1, 1, 0, 5, 6, 0, 5, 3, 1, 3, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {5, 0, 6, 0, 0, 6, 0, 0, 7, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 5} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {7, 0, 1, 0, 0, 8, 0, 0, 7, 0, 6, 1, 0, 6, 2, 0, 1, 0, 7, 3, 0, 0, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 4} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {5, 0, 0, 0, 0, 6, 0, 0, 7, 0, 3, 3, 0, 3, 4, 0, 3, 0, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 5} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {6, 0, 0, 0, 0, 7, 0, 0, 6, 0, 0, 0, 0, 2, 0, 0, 2, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 1, 0, 1} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {1, 4, 7, 3, 5, 7, 1, 5, 1, 7, 5, 5, 6, 2, 1, 5, 5, 5, 6, 0, 0, 7, 0, 5, 4, 1, 0, 1, 0, 0, 0, 1, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 1, 0, 0, 0, 3, 0, 7, 1, 0, 6, 0, 4, 7, 1, 0, 0, 6, 4, 0, 0, 0, 0, 1, 6, 1, 0, 0, 0, 0, 6, 2, 8} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 0, 4, 0, 0, 1, 0, 0, 0, 2, 6, 5, 2, 1, 0, 2, 0, 1, 7, 0, 4, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 5, 0, 0, 2, 0, 1, 2, 0, 4, 1, 0, 0, 0, 0, 0, 0, 3, 7, 0, 0, 0, 0, 6, 1, 7, 0, 0, 1, 0, 3, 0, 7} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {0, 1, 5, 2, 5, 6, 2, 5, 0, 2, 2, 3, 6, 5, 0, 1, 4, 4, 7, 0, 0, 4, 4, 3, 0, 4, 0, 0, 0, 0, 6, 4, 9} },
                                             new BiCoeffLine() { BiCoeff = new List<int>() {7, 8, 9, 7, 8, 7, 5, 8, 8, 3, 8, 6, 8, 9, 9, 9, 8, 9, 8, 7, 7, 6, 7, 8, 5, 1, 1, 2, 1, 8, 2, 6, 0} } };

        List<List<char>>[] inputTable = new List<List<char>>[9], // исходный шифротекст
                           updatedTable = new List<List<char>>[9]; // шифротекст (переставлены столбцы)

        List<List<char>> inputText = new List<List<char>>(), // исходный текст
                         updatedText = new List<List<char>>(), // шифротекст (переставлены столбцы)
                         outputText = new List<List<char>>(); // шифротекст (переставлены строки)

        List<int> codeLength = new List<int>();

        List<string> rusDictionary = new List<string>(), possibleCombinations = new List<string>();
        // http://speakrus.ru/dict/index.htm

        public Bigram()
        {
            try
            {
                InitializeComponent();

                // загрузка словаря русских слов
                if (File.Exists("dictionary.bin"))
                {
                    StreamReader sr = new StreamReader("dictionary.bin", Encoding.Default);
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                        rusDictionary.Add(line.ToUpper());
                }
                else
                {
                    MessageBox.Show("Файл словаря не найден! Модуль дешифровки с использованием словаря будет отключен!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    useDictionaryCheckBox.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + e.Message + "'; " + e.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public List<Combination> getWeightedKeyCombinations(int codeLength, int index)
        {
            try
            {
                // составление списка возможных перестановок столбцов
                int[] nums = Enumerable.Range(1, codeLength).ToArray();
                List<string> combinationsList = new List<string>();
                showAllCombinations(nums, combinationsList);
                List<Combination> combinations = new List<Combination>();

                // подсчет вероятностей для каждой из перестановок
                foreach (string combination in combinationsList)
                {
                    string[] cm = combination.Split('-');
                    int[] indexes = new int[cm.Count()];
                    for (int i = 0; i < cm.Count(); i++)
                        indexes[i] = (int)Char.GetNumericValue(cm[i][0]) - 1;

                    int combinationWeight = 0;

                    for (int i = 0; i < cm.Count() - 1; i++)
                    {
                        List<List<char>> lst = inputTable[index];
                        for (int j = 0; j < lst.Count; j++)
                        {
                            combinationWeight += coeffTable.getCoeff(lst[j][indexes[i]], lst[j][indexes[i + 1]]);
                        }
                    }

                    combinations.Add(new Combination(combination, combinationWeight));
                }

                return combinations;
            }
            catch (Exception e)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + e.Message + "'; " + e.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return null;
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                keysListBox.Items.Clear();
                decryptListBox.Items.Clear();
                inputTable = new List<List<char>>[9];
                codeLength.Clear();

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // загрузка закодированного текста
                    StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Length % 9 == 0)
                            codeLength.Add(9);
                        if (line.Length % 8 == 0)
                            codeLength.Add(8);
                        if (line.Length % 7 == 0)
                            codeLength.Add(7);
                        if (line.Length % 6 == 0)
                            codeLength.Add(6);
                        if (line.Length % 5 == 0)
                            codeLength.Add(5);
                        if (line.Length % 4 == 0)
                            codeLength.Add(4);
                        if (line.Length % 3 == 0)
                            codeLength.Add(3);
                        if (line.Length % 2 == 0)
                            codeLength.Add(2);

                        List<int> toRemove = new List<int>();

                        foreach (int cLength in codeLength)
                            if (line.Length / cLength > 6)
                                toRemove.Add(cLength);

                        foreach (int item in toRemove)
                            codeLength.Remove(item);

                        if (codeLength.Count == 0)
                        {
                            MessageBox.Show("Дешифрование сообщения такой длины не осуществляется!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (line.Contains('Ё'))
                        {
                            char[] ln = line.ToCharArray();
                            for (int i = 0; i < ln.Count(); i++)
                                if (ln[i] == 'Ё') ln[i] = 'Е';
                            line = new string(ln);
                        }

                        int rus = line.ToLowerInvariant().Where(c => Char.IsLetter(c) && (int)c >= 1072 && (int)c <= 1103).Count();

                        if (rus != string.Join("", line.Split(' ')).Length)
                        {
                            MessageBox.Show("Сообщение повреждено, дешифрование невозможно!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        for (int k = 0; k < codeLength.Count; k++)
                        {
                            List<List<char>> list = new List<List<char>>();
                            for (int i = 0; i < line.Length / codeLength[k]; i++)
                            {
                                List<Char> charLine = new List<char>();
                                for (int j = 0; j < codeLength[k]; j++)
                                {
                                    charLine.Add(line[i * codeLength[k] + j]);
                                }
                                list.Add(charLine);
                            }
                            inputTable[k] = list;
                        }

                        //string[] ln = line.Split(',');
                        //List<Char> charLine = new List<char>();
                        //foreach (string ch in ln)
                        //{
                        //    if (ch.Length == 1)
                        //        charLine.Add(ch[0]);
                        //}
                        //inputTable.Add(charLine);
                    }
                    sr.Close();

                    List<Combination> combinations = new List<Combination>();
                    for (int i = 0; i < codeLength.Count; i++)
                        combinations.AddRange(getWeightedKeyCombinations(codeLength[i], i));
                    List<Combination> sortedComb = combinations.OrderByDescending(c => c.weight).ToList();

                    // сохранение списка комбинаций, отсортированного по убыванию весов
                    //if (sortedComb.Count > 500)
                    //    for (int i = 0; i < (int)(sortedComb.Count() / 10); i++)
                    //        keysListBox.Items.Add(sortedComb[i].comb);
                    //else
                    for (int i = 0; i < codeLength.Count; i++)
                        if (codeLength[i] > 0)
                        {
                            int count = sortedComb.FindAll(c => c.comb.Split('-').Length == codeLength[i]).Count;
                            Combination[] only50 = new Combination[codeLength[i] * 10];
                            if (count > codeLength[i] * 10)
                                sortedComb.FindAll(c => c.comb.Split('-').Length == codeLength[i]).CopyTo(0, only50, 0, codeLength[i] * 10);
                            else
                            {
                                only50 = new Combination[count];
                                sortedComb.FindAll(c => c.comb.Split('-').Length == codeLength[i]).CopyTo(0, only50, 0, count);
                            }
                            foreach (Combination comb in only50)
                                keysListBox.Items.Add(string.Join("",comb.comb.Split('-')));
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + ex.Message + "'; " + ex.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public static void showAllCombinations<T>(IList<T> arr, List<string> result, string current = "")
        {
            try
            {
                if (arr.Count == 0)
                {
                    result.Add(current);
                    return;
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    List<T> lst = new List<T>(arr);
                    lst.RemoveAt(i);
                    if (current == "")
                        showAllCombinations(lst, result, current + arr[i].ToString());
                    else
                        showAllCombinations(lst, result, current + "-" + arr[i].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + e.Message + "'; " + e.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void keysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decryptListBox.Items.Clear();
                updatedTable = new List<List<char>>[9];
                possibleCombinations.Clear();

                if (keysListBox.SelectedIndex > -1)
                {
                    //string[] key = keysListBox.SelectedItem.ToString().Split('-');
                    string key = keysListBox.SelectedItem.ToString();
                    int index = codeLength.IndexOf(key.Count());
                    // перестановка столбцов местами в соответствии с ключом
                    int[] indxs = new int[key.Count()];
                    for (int i = 0; i < key.Count(); i++)
                        indxs[i] = (int)Char.GetNumericValue(key[i]) - 1;

                    List<List<char>> list = new List<List<char>>();
                    for (int i = 0; i < inputTable[index].Count; i++)
                    {
                        List<char> updatedLine = new List<char>();
                        for (int j = 0; j < indxs.Count(); j++)
                            updatedLine.Add(inputTable[index][i][indxs[j]]);
                        list.Add(updatedLine);
                    }
                    updatedTable[index] = list;

                    // составление списка возможных перестановок строк
                    int[] numbs = Enumerable.Range(1, inputTable[index].Count).ToArray();
                    List<string> combList = new List<string>();
                    showAllCombinations(numbs, combList);
                    List<string> lineCombinations = new List<string>();

                    // составление комбинаций строк по числу перестановок
                    foreach (string lComb in combList)
                    {
                        string[] com = lComb.Split('-');
                        int[] inds = new int[com.Count()];
                        for (int i = 0; i < com.Count(); i++)
                            inds[i] = (int)Char.GetNumericValue(com[i][0]) - 1;

                        string resString = "";

                        List<List<char>> lst = updatedTable[index];
                        for (int i = 0; i < inds.Count(); i++)
                            resString += new string(lst[inds[i]].ToArray());

                        lineCombinations.Add(resString);
                    }

                    Cursor = Cursors.WaitCursor;
                    // поиск слов из каждой комбинации в словаре
                    foreach (string comb in lineCombinations)
                    {
                        if (useDictionaryCheckBox.Enabled && useDictionaryCheckBox.Checked)
                        {
                            string[] words = comb.Split(' ');
                            int found = 0;

                            foreach (string word in words)
                            {
                                List<string> partsOfWord = new List<string>();
                                if (word != words.Last() && word.Length <= 5 && word.Length > 3)
                                    partsOfWord.Add(word.Substring(0, word.Length - 1));
                                else if (word != words.Last() && word.Length > 5)
                                    partsOfWord.Add(word.Substring(0, word.Length - 2));
                                else if (word != words.Last() && word.Length > 7)
                                    partsOfWord.Add(word.Substring(0, word.Length - 3));
                                else if (word == words.Last() && word.Length > 2)
                                {
                                    int k = 0;
                                    while (k < key.Length + 1 && word.Length - k > 5)
                                    {
                                        k++;
                                        partsOfWord.Add(word.Substring(0, word.Length - k));
                                    }
                                }

                                bool f = false;

                                if (word != "" && !f)
                                {
                                    if (rusDictionary.Find(str => str == word) != null)
                                    {
                                        found++;
                                        f = true;
                                    }
                                }
                                if (partsOfWord.Count > 0)
                                    foreach (string wrd in partsOfWord)
                                        if (!f)
                                        {
                                            if (rusDictionary.Find(str => str.Contains(wrd) && str.First() == wrd.First()) != null)
                                            {
                                                found++;
                                                f = true;
                                            }
                                        }
                                        else
                                            break;
                            }

                            if (found == words.Count())
                                possibleCombinations.Add(string.Join(" ", words));
                        }
                        else
                            possibleCombinations.Add(comb);
                    }

                    foreach (string combination in possibleCombinations)
                        decryptListBox.Items.Add(combination);

                    if (possibleCombinations.Count == 0)
                        decryptListBox.Items.Add("Ошибка: не удалось дешифровать текст для выбранного ключа!");

                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + ex.Message + "'; " + ex.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void encryptTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != '\b' && ch != ' ')
                e.Handled = true;
        }

        private void keyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != '\b')
                e.Handled = true;
            else if (keyTextBox.Text.Contains(ch) || ch == '0')
                e.Handled = true;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptText = encryptTextBox.Text, key = keyTextBox.Text;
                if (encryptText == "")
                    MessageBox.Show("Введите текст для шифрования!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (key == "")
                        MessageBox.Show("Введите ключ для шифрования!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        bool incorrect1 = false, incorrect2 = false;
                        for (int i = key.Length + 1; i <= 9; i++)
                            if (key.Contains((i).ToString()))
                            {
                                incorrect1 = true;
                                break;
                            }

                        if (key.Length <= 1)
                            incorrect2 = true;

                        if (incorrect1)
                            MessageBox.Show("Неверный формат ключа!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (incorrect2)
                            MessageBox.Show("Слишком короткий ключ!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (encryptText.Length < key.Length)
                                MessageBox.Show("Длина текста не может быть меньше длины ключа!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (encryptText.Length > key.Length * 6)
                                {
                                    MessageBox.Show("Длина текста не может быть больше, чем <длина ключа * 6>!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                Cursor = Cursors.WaitCursor;

                                inputText.Clear();
                                updatedText.Clear();
                                outputText.Clear();

                                // сохранение текста в таблице
                                int count = 0;
                                if (encryptText.Length % key.Length == 0)
                                    count = encryptText.Length / key.Length;
                                else
                                    count = (int)Math.Floor((double)encryptText.Length / (double)key.Length) + 1; // количество строк в таблице
                                for (int i = 0; i < count; i++)
                                {
                                    List<char> inputLine = new List<char>();
                                    int curr = 0;
                                    while (curr < key.Length)
                                    {
                                        if ((curr + i * key.Length) < encryptText.Length)
                                            inputLine.Add(char.ToUpper(encryptText[curr + i * key.Length]));
                                        else
                                        {
                                            Random rnd = new Random();
                                            inputLine.Add(char.ToUpper((char)(rnd.Next(1040, 1104))));
                                            System.Threading.Thread.Sleep(100);
                                        }
                                        curr++;
                                    }
                                    inputText.Add(inputLine);
                                }

                                // ключ
                                int[] keyIndexes = new int[key.Length];
                                for (int i = 0; i < key.Length; i++)
                                    keyIndexes[i] = (int)Char.GetNumericValue(key[i]) - 1;

                                // перестановка столбцов
                                for (int i = 0; i < inputText.Count; i++)
                                {
                                    char[] updatedLine = new char[key.Length];
                                    for (int j = 0; j < keyIndexes.Count(); j++)
                                        updatedLine[keyIndexes[j]] = inputText[i][j];
                                    updatedText.Add(updatedLine.ToList());
                                }

                                // генерация случайного ключа для перестановки строк
                                int[] keyIndexesLines = new int[updatedText.Count];
                                for (int i = 0; i < updatedText.Count; i++)
                                    keyIndexesLines[i] = -1;
                                for (int i = 0; i < updatedText.Count; i++)
                                {
                                    Random rnd = new Random();
                                    int rand = 0;
                                    do
                                    {
                                        rand = rnd.Next(0, updatedText.Count);
                                        System.Threading.Thread.Sleep(100);
                                    }
                                    while (keyIndexesLines.Contains(rand));
                                    keyIndexesLines[i] = rand;
                                }

                                // перестановка строк
                                for (int i = 0; i < updatedText.Count; i++)
                                {
                                    List<char> outputLine = updatedText[keyIndexesLines[i]];
                                    outputText.Add(outputLine);
                                }

                                Cursor = Cursors.Default;

                                if (MessageBox.Show("Показать матрицы шифрованного текста?", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Form matrixForm = new Form();
                                    matrixForm.StartPosition = FormStartPosition.CenterScreen;
                                    matrixForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                                    matrixForm.Size = new Size(updatedText[0].Count * 100 + 66, updatedText.Count * 50 + 103);
                                    matrixForm.Text = "BIGRAM ENCRYPTOR/DECRYPTOR";

                                    Label matrix1Label = new Label();
                                    matrix1Label.Parent = matrixForm;
                                    matrix1Label.Location = new Point(15, 15);
                                    matrix1Label.Text = "Только столбцы:";
                                    matrix1Label.Width = 150;
                                    matrixForm.Controls.Add(matrix1Label);

                                    DataGridView matrix1 = new DataGridView();
                                    matrix1.Parent = matrixForm;
                                    matrix1.Location = new Point(15, 40);
                                    matrix1.Size = new Size(updatedText[0].Count * 50 + 1, updatedText.Count * 50 + 1);
                                    matrix1.RowTemplate.Height = 50;
                                    matrix1.RowHeadersVisible = false;
                                    matrix1.ColumnHeadersVisible = false;
                                    matrix1.ScrollBars = ScrollBars.None;
                                    matrix1.BorderStyle = BorderStyle.None;
                                    matrix1.Enabled = false;
                                    matrix1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                                    matrix1.MultiSelect = false;
                                    matrix1.SelectionChanged += matrix1_SelectionChanged;
                                    for (int i = 0; i < updatedText[0].Count; i++)
                                    {
                                        matrix1.Columns.Add("m1column" + i, "");
                                        matrix1.Columns[i].Width = 50;
                                        matrix1.Columns[i].DefaultCellStyle.Font = new Font("Arial", 34, GraphicsUnit.Pixel);
                                    }
                                    foreach (List<char> row in updatedText)
                                    {
                                        string[] rw = new string[updatedText[0].Count];
                                        for (int i = 0; i < row.Count; i++)
                                            rw[i] = row[i].ToString();
                                        matrix1.Rows.Add(rw);
                                    }
                                    matrixForm.Controls.Add(matrix1);

                                    Label matrix2Label = new Label();
                                    matrix2Label.Parent = matrixForm;
                                    matrix2Label.Location = new Point(30 + updatedText[0].Count * 50, 15);
                                    matrix2Label.Text = "Столбцы и строки:";
                                    matrix2Label.Width = 200;
                                    matrixForm.Controls.Add(matrix2Label);

                                    DataGridView matrix2 = new DataGridView();
                                    matrix2.Parent = matrixForm;
                                    matrix2.Location = new Point(30 + updatedText[0].Count * 50, 40);
                                    matrix2.Size = new Size(updatedText[0].Count * 50 + 1, updatedText.Count * 50 + 1);
                                    matrix2.RowTemplate.Height = 50;
                                    matrix2.RowHeadersVisible = false;
                                    matrix2.ColumnHeadersVisible = false;
                                    matrix2.ScrollBars = ScrollBars.None;
                                    matrix2.BorderStyle = BorderStyle.None;
                                    matrix2.Enabled = false;
                                    matrix2.SelectionMode = DataGridViewSelectionMode.CellSelect;
                                    matrix2.MultiSelect = false;
                                    matrix2.SelectionChanged += matrix1_SelectionChanged;
                                    for (int i = 0; i < updatedText[0].Count; i++)
                                    {
                                        matrix2.Columns.Add("m2column" + i, "");
                                        matrix2.Columns[i].Width = 50;
                                        matrix2.Columns[i].DefaultCellStyle.Font = new Font("Arial", 34, GraphicsUnit.Pixel);
                                    }
                                    foreach (List<char> row in outputText)
                                    {
                                        string[] rw = new string[updatedText[0].Count];
                                        for (int i = 0; i < row.Count; i++)
                                            rw[i] = row[i].ToString();
                                        matrix2.Rows.Add(rw);
                                    }
                                    matrixForm.Controls.Add(matrix2);

                                    matrixForm.ShowDialog();
                                }

                                SaveFileDialog sfd = new SaveFileDialog();
                                sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
                                sfd.FilterIndex = 1;
                                sfd.RestoreDirectory = true;

                                StreamWriter sw;

                                if (sfd.ShowDialog() == DialogResult.OK)
                                {
                                    if ((sw = new StreamWriter(sfd.OpenFile(), Encoding.Default)) != null)
                                    {
                                        foreach (List<char> line in outputText)
                                            sw.Write(new string(line.ToArray()));
                                        sw.Close();

                                        MessageBox.Show("Успешно сохранено!", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        encryptTextBox.Text = "";
                                        keyTextBox.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + ex.Message + "'; " + ex.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        void matrix1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }

        private void useDictionaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decryptListBox.Items.Clear();
            keysListBox.ClearSelected();
        }

        private void decryptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (decryptListBox.SelectedIndex > -1 && decryptListBox.SelectedItem.ToString() != "Ошибка: не удалось дешифровать текст для выбранного ключа!")
                {
                    if (MessageBox.Show("Показать матрицу дешифрованного текста?", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string key = keysListBox.SelectedItem.ToString();
                        int index = codeLength.IndexOf(key.Length);

                        Form matrixForm = new Form();
                        matrixForm.StartPosition = FormStartPosition.CenterScreen;
                        matrixForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                        matrixForm.Size = new Size(updatedTable[index][0].Count * 50 + 51, updatedTable[index].Count * 50 + 78);
                        matrixForm.Text = "BIGRAM ENCRYPTOR/DECRYPTOR";

                        DataGridView matrix1 = new DataGridView();
                        matrix1.Parent = matrixForm;
                        matrix1.Location = new Point(15, 15);
                        matrix1.Size = new Size(updatedTable[index][0].Count * 50 + 1, updatedTable[index].Count * 50 + 1);
                        matrix1.RowTemplate.Height = 50;
                        matrix1.RowHeadersVisible = false;
                        matrix1.ColumnHeadersVisible = false;
                        matrix1.ScrollBars = ScrollBars.None;
                        matrix1.BorderStyle = BorderStyle.None;
                        matrix1.Enabled = false;
                        matrix1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        matrix1.MultiSelect = false;
                        matrix1.SelectionChanged += matrix1_SelectionChanged;
                        for (int i = 0; i < updatedTable[index][0].Count; i++)
                        {
                            matrix1.Columns.Add("m1column" + i, "");
                            matrix1.Columns[i].Width = 50;
                            matrix1.Columns[i].DefaultCellStyle.Font = new Font("Arial", 34, GraphicsUnit.Pixel);
                        }
                        string value = decryptListBox.SelectedItem.ToString();
                        int count = value.Length / key.Length;
                        for (int i = 0; i < count; i++)
                        {
                            string[] rw = new string[key.Length];
                            for (int j = 0; j < key.Length; j++)
                                rw[j] = value[i * key.Length + j].ToString();
                            matrix1.Rows.Add(rw);
                        }
                        matrixForm.Controls.Add(matrix1);

                        matrixForm.ShowDialog();
                    }
                }
                decryptListBox.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка, дальнейшее продолжение работы программы невозможно! Пожалуйста, передайте разработчику следующие сведения: ('" + ex.Message + "'; " + ex.LineNumber() + ").", "BIGRAM ENCRYPTOR/DECRYPTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void devLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/dpahomov");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigramAbout bA = new BigramAbout();
            bA.ShowDialog();
        }
    }

    public class BiCoeff : List<BiCoeffLine>
    {
        private List<char> alphabet = Enumerable.Range(0, 32).Select((x, i) => (char)('А' + i)).ToList();

        public int getCoeff(char s1, char s2)
        {
            int coeff = 0;
            if (s1 == ' ' && s2 == ' ') coeff = 0;
            else if (s1 == ' ' && s2 != ' ') coeff = this[32].BiCoeff[alphabet.IndexOf(s2)];
            else if (s2 == ' ' && s1 != ' ') coeff = this[alphabet.IndexOf(s1)].BiCoeff[32];
            else coeff = this[alphabet.IndexOf(s1)].BiCoeff[alphabet.IndexOf(s2)];
            return coeff;
        }
    }

    public class BiCoeffLine
    {
        public List<int> BiCoeff = new List<int>();
    }

    public class Combination
    {
        public string comb = "";
        public int weight = 0;

        public Combination(string _comb, int _weight)
        {
            comb = _comb;
            weight = _weight;
        }
    }

    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {
            int linenum = 0;
            try
            {
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' ')));
            }
            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }
    }
}
