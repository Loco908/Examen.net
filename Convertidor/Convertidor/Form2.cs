using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class Form2 : Form
    {
        private String local;
        private String a;
        List<String> list2 = new List<String>();
        List<CheckBox> list3 = new List<CheckBox>();
        List<String> list4 = new List<String>();
        public Form2()
        {
            InitializeComponent();
        }

        public string Local { get => local; set => local = value; }
        public string A { get => a; set => a = value; }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            list.Add("MXN - Peso mexicano");
            list.Add("USD - Dólar estadounidense");
            list.Add("CAD - Dólar canadiense");
            list.Add("EUR - Euro");
            list.Add("JPY - Yen japonés");


            foreach(String s in list)
            {
                if(s == local)
                {

                }
                else
                {
                    list2.Add(s);
                }
            }
            int p = 10;
            int j = 10;
           
            foreach(String s in list2)
            {
                CheckBox c = new CheckBox();
                c.Size = new Size(130, 30);
                c.Text = s;
                c.Location = new Point(p, j);
                this.Controls.Add(c);
                list3.Add(c);
                j = j + 35;
            }
        

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
            foreach (CheckBox s in list3)
            {
                if (s.Checked == true)
                {
                    list4.Add(s.Text);
                }

            }


            foreach(String s in list4)
            {
                Console.WriteLine(s);
            }
        }
    }
}
