using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace GenericAlgo
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Form2());
        }

        
    }

    class Form2 : Form1
    {
        Button button1;
        int count = 0;


        public Form2()
        {
            this.Height = 200;
            this.Width = 200;
            this.Text = "test";

            this.button1 = new Button();
            this.button1.Location = new Point(10, 10);
            this.button1.Size = new Size(170, 30);
            this.button1.Text = "push";

            this.button1.Click += new EventHandler(this.buttonClick);

            this.Controls.Add(this.button1);


        }

        void buttonClick(Object sender, EventArgs e)
        {
            this.count++;
            this.button1.Text = count.ToString();

        }

    }
}
