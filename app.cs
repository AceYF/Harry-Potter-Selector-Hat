using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Selector_Hat
{
    public partial class app : Form
    {
        string notepad;
        public app()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void grifinoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            tb_name.Visible = false;
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = true;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            notepad = File.ReadAllText("alunosgrifinoria.txt") + Environment.NewLine;
            webBrowser1.DocumentText = notepad;
            webBrowser1.Visible = true;

        }

        private void app_Load(object sender, EventArgs e)
        {
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = false;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            webBrowser1.Visible = false;
        }

        private void sonserinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            tb_name.Visible = false;
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = true;
            pb_grifinoria.Visible = false;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            notepad = File.ReadAllText("alunossonserina.txt") + Environment.NewLine;
            webBrowser1.DocumentText = notepad;
            webBrowser1.Visible = true;
        }
    
    

        private void lufaLufaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            tb_name.Visible = false;
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = true;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = false;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            notepad = File.ReadAllText("alunoslufalufa.txt") + Environment.NewLine;
            webBrowser1.DocumentText = notepad;
            webBrowser1.Visible = true;
        }
    

        private void corvinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            tb_name.Visible = false;
            pb_corvinal.Visible = true;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = false;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            notepad = File.ReadAllText("alunoscorvinal.txt") + Environment.NewLine;
            webBrowser1.DocumentText = notepad;
            webBrowser1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            Timer timerduvida = new Timer();
            nome = tb_name.Text + Environment.NewLine;
            tb_name.Text = "";
            
            SoundPlayer _duvida,_grifinoria,_sonserina,_lufalufa,_corvinal;
            _duvida = new SoundPlayer("duvida.wav");
            _duvida.PlaySync();

            _grifinoria = new SoundPlayer("Grifinoriawav.wav");
            _sonserina = new SoundPlayer("sonserinawav.wav");
            _lufalufa = new SoundPlayer("lufalufawav.wav");
            _corvinal = new SoundPlayer("corvinalwav.wav");

            string[] casas = {
                "Grifinoria",
                "Sonserina",
                "Lufa-Lufa",
                "Corvinal"
            };
            var rand = new Random();
            var nextRandString = rand.Next(0, 5 - 1);
            var randstring = casas[nextRandString];
            
            if(randstring == "Grifinoria")
            {
                _grifinoria.Play();
                File.AppendAllText("alunosgrifinoria.txt", nome);
            }
            if (randstring == "Sonserina")
            {
                _sonserina.Play();
                File.AppendAllText("alunossonserina.txt", nome);
            }
            if (randstring == "Lufa-Lufa")
            {
                _lufalufa.Play();
                File.AppendAllText("alunoslufalufa.txt", nome);

            }
            if(randstring == "Corvinal")
            {
                _corvinal.Play();
                File.AppendAllText("alunoscorvinal.txt", nome);
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto1.Visible = true;
            texto4.Visible = true;
            lb_meunome.Visible = true;
            pb_eu.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            tb_name.Visible = false;
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = false;
            webBrowser1.Visible = false;
        }

        private void selectorHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            tb_name.Visible = true;
            button1.Visible = true;
            pb_corvinal.Visible = false;
            pb_lufalufa.Visible = false;
            pb_sonserina.Visible = false;
            pb_grifinoria.Visible = false;
            texto1.Visible = false;
            texto4.Visible = false;
            lb_meunome.Visible = false;
            pb_eu.Visible = false;
            webBrowser1.Visible = false;
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126) { 
                e.Handled = true;
        }
            if (tb_name.TextLength < 2 || tb_name.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
