using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person1 = new Person("Riccardo", "Miosi", 16);
            Student student1 = new Student("Tizio", "Caio", 17, "4^E");
            //person1.describe();
        }
    }
}
