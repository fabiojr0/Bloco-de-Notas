using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class Form1 : Form

        
    {
        bool alterado;
        int zoom = 100;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            this.Location = new Point(Int32.Parse(config.AppSettings.Settings["windownPositionX"].Value),
                Int32.Parse(config.AppSettings.Settings["windownPositionY"].Value));
            this.Size = new Size(Int32.Parse(config.AppSettings.Settings["sizeW"].Value),
                Int32.Parse(config.AppSettings.Settings["sizeH"].Value));

            barraDeStatusToolStripMenuItem.Checked = true;
            atualizaPosicao();
        }
        private void atualizaPosicao()
        {
            int linha = TextBox.GetLineFromCharIndex(TextBox.SelectionStart);
            int coluna = TextBox.SelectionStart - TextBox.GetFirstCharIndexFromLine(linha);
            labelCursor.Text = "Ln:" + linha + "Col:" + coluna;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            atualizaPosicao();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.abrir();

            }
            else
            {
                if(MessageBox.Show("Seu arquivo foi alterado. Deseja Salvar?",
                    "Bloco de Notas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                }else
                {
                    if(this.Text != "")
                    {
                        this.salvar(this.Text);
                    }else
                    {
                        this.salvarComo();
                    }
                }
            }
        }
        

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text != "")
            {
                this.salvar(this.Text);
            }else
            {
                this.salvarComo();
            }
        }
        private void abrir()
            { 

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Text = openFileDialog1.FileName;
                    using (StreamReader reader = new StreamReader(openFileDialog1.OpenFile()))
                    {
                        TextBox.Rtf = reader.ReadToEnd();
                        alterado = false;
                    }
                }
            
        }
        private void salvar(string arquivo)
        {
            if(arquivo != "") {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(TextBox.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            }else
            {
                MessageBox.Show("Nomo de arquivo inválido!","Salvar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void salvarComo()
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.salvar(saveFileDialog1.FileName);
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TextBox.SelectedRtf != "")
            {
                Clipboard.SetDataObject(TextBox.SelectedRtf);
                TextBox.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedRtf != "")
            {
                Clipboard.SetDataObject(TextBox.SelectedRtf);         
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                TextBox.SelectedText = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedRtf != "")
            {              
                TextBox.SelectedRtf = "";
            }
        }

        private void buscarComGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedRtf != "")
            {
                String Texto = TextBox.SelectedText;
                Texto.Replace(' ', '+');
                System.Diagnostics.Process.Start("microsoft-edge:https://www.google.com/search?q=" + Texto);
            } else
            {
                MessageBox.Show("É necessário selecionar um termo para pesquisar",
                    "Buscar com google",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        private void datahoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraDeLinhaAutomáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraDeLinhaAutomáticaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraDeLinhaAutomáticaToolStripMenuItem.CheckState = CheckState.Unchecked;
                TextBox.WordWrap = false;
            } else
            {
                quebraDeLinhaAutomáticaToolStripMenuItem.CheckState = CheckState.Checked;
                TextBox.WordWrap = true;
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                TextBox.Text = "";
                alterado = false;
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja Salvar?",
                    "Bloco de Notas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    TextBox.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox.SelectionFont = fontDialog1.Font;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.AppSettings.Settings["windownPositionX"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["windownPositionY"].Value = this.Location.Y.ToString();
            config.AppSettings.Settings["sizeH"].Value = this.Size.Height.ToString();
            config.AppSettings.Settings["sizeW"].Value = this.Size.Width.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void Infos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            Infos.Visible = !Infos.Visible;
        }

        private void atualizaZoom()
        {
            labelZoom.Text = this.zoom.ToString() + "%";
        }

        private void aplicarZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            TextBox.Font = new Font(TextBox.Font.FontFamily, TextBox.Font.Size + 1, TextBox.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            TextBox.Font = new Font(TextBox.Font.FontFamily, TextBox.Font.Size - 1, TextBox.Font.Style);
            this.atualizaZoom();
        }

        private void restaurarZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            TextBox.Font = new Font(TextBox.Font.FontFamily, 12, TextBox.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
