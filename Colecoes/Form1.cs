using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            

            lista.Items.Clear();
            strings.Add("Item 1");
            strings.Add("Item 2");

            strings.AddRange(new string[] { "MAURO", "SIM", "NAO" });
            strings.Insert(3, "penetra");
            strings.Sort();


          /*  if (strings.Remove(strings[0]))
            {
                MessageBox.Show($"{strings[0]} removido ");
            }*/
            
           /* if (strings.Contains("MAURO"))
            {
                MessageBox.Show("Contém");
            }else
            {
                MessageBox.Show("Nao Contém");
            }*/




                foreach (string s in strings)
                {
                    lista.Items.Add(s);
                }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear ();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Aviao", "Helicoptero", "Barco"
            };

            foreach (string v in veiculos)
            {
                lista.Items.Add(v);
            }


        }

        private void btnDict_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {10,"molr" },
                {11, "losr" }

            };

            dict.Add(1, "miro");
            dict.Add(2, "noei");

            foreach (KeyValuePair<int,string> v in dict)
            {
                lista.Items.Add(v.Value);
            }
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>()
            {
                {3, "terceiro"},
                {1, "primeiro" },
                {4, "quarot" }
            };

            keyValuePairs.Add(2, "segundo");

            foreach (KeyValuePair <int,string> v in keyValuePairs)
            {
                lista.Items.Add (v);
            }


        }

        private void btnSortedDict_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>()
            {
                {10, "mauro" },
                {2, "joao" },
                {301, "pedro" },
                {1, "vitor" }
            };

            sortedDict.Add(97, "tiago");

            foreach (KeyValuePair<int, string> v in sortedDict)
            {
                lista.Items.Add(v);
            }
                

        }
    }
}
