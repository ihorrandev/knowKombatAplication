using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowKombat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lógicas primárias da aplicação


        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox3.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label5.Visible = true;
                label4.Text = "Primeiramente, antes mesmo da narrativa construída pelo primeiro Mortal Kombat, existe uma história prévia. No mundo do jogo, existem várias dimensões regidas por Deuses Anciões. Os mais importantes para o jogo são Outworld, que conquista outros mundos à; Edenia, terra de fertilidade conquistada por Outworld; Netherrealm, uma versão do inferno; e Earthrealm, a Terra. Uma vez que o Outworld sempre tenta dominar outros reinos, os Deuses decidiram por ordem nas coisas. Entretanto, a solução não foi muito convencional. Eles criaram um torneio de luta que dá o direito de dominar a dimensão sede a quem vencer dez edições seguidas: o Mortal Kombat.";

                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                radioButton17.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                checkBox1.Visible = false;
                pictureBox2.Visible = false;
                label3.Visible = false;
                checkBox2.Visible = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                this.pictureBox3.Image = null;
                comboBox2.Visible = false;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;

            }
            else if (listBox1.SelectedIndex == 1)
            {
                label4.Visible = false;
                label5.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                radioButton16.Visible = true;
                radioButton17.Visible = true;
                label2.Visible = false;
                comboBox1.Visible = false;
                checkBox1.Visible = false;
                pictureBox2.Visible = false;
                label3.Visible = false;

                checkBox2.Visible = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                this.pictureBox3.Image = null;
                comboBox2.Visible = false;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;

            }
            else if(listBox1.SelectedIndex==2){

                label4.Visible = false;
                label5.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                radioButton17.Visible = false;


                label2.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox2.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                this.pictureBox3.Image = null;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                pictureBox2.Image = null;
                label3.Text = "";

                comboBox2.Visible = false;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }


        //Jogos | Aqui fica todo o código em relação aos jogos da aplicação


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;
                this.pictureBox2.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                label3.Text = "";

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;
                this.pictureBox2.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                label3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;
                this.pictureBox2.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                label3.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {

                if (checkBox1.Checked == true)
                {
                    pictureBox2.Image = Properties.Resources.Mk9_logo;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }

            }else if (comboBox1.SelectedIndex == 2)
            {

                if (checkBox1.Checked == true)
                {
                    pictureBox2.Image = Properties.Resources.Mk10_logo;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }

            }else if (comboBox1.SelectedIndex == 3)
            {

                if (checkBox1.Checked == true)
                {
                    pictureBox2.Image = Properties.Resources.Mk11_logo;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked == true)
                {
                    label3.Text = "O enredo envolve o protetor divino da Terra, Raiden, tentando mudar as consequências dos eventos do Armagedon, contando seu próprio passado enquanto enfrenta a derrota nas mãos do imperador de Outworld, Shao Kahn.";
                }else
                {
                    label3.Text = "";
                }
            }else if (comboBox1.SelectedIndex == 2)
            {
                if (checkBox2.Checked == true)
                {
                    label3.Text = "A história começa no final do jogo anterior e, eventualmente avnça 20 anos para o futuro, dando enfase a veteranos idosos, novos personagens e aos filhos da antiga geração de lutadores. Enquanto isso Mileena tenta conquistar seu trono por direito que foi roubado por Kotal Khan.";
                }
                else
                {
                    label3.Text = "";
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                if (checkBox2.Checked == true)
                {
                    label3.Text = "Após o final do mortal kombat 10, Kronica, uma titã do tempo, decide reiniciar a história mas não tendo a aprovação de muitos ela faz isso a força e dentro da história a equipe original tenta vencer as reviravoltas que Kronica faz, ela se alia aos corrompidos e faz com que os guerreiros do presente e do passado se unirem para frustar o tempo perdido de Kronica.";
                }
                else
                {
                    label3.Text = "";
                }
            }
            else
            {
                label3.Text = "";
            }
            
        }

       
        
        //Personagens | Aqui fica todo o código em relação aos personagens mostrados na aplicação


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                comboBox2.Visible = true;
                pictureBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                pictureBox3.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem certeza que deseja sair do Know Kombat?", "Atenção", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (DialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                if (radioButton2.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_scorpion9;
                }else if (radioButton1.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_subzero9;
                }else if (radioButton3.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_repitile9;
                }else if (radioButton4.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kitana9;
                }else if (radioButton5.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jade9;
                }else if (radioButton6.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_mileena9;
                }else if (radioButton7.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_baraka9;
                }else if (radioButton8.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_raiden9;
                }else if (radioButton9.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sonya9;
                }else if (radioButton10.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_johnny9;
                }else if (radioButton11.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jax9;
                }else if (radioButton13.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_luikang9;
                }else if (radioButton14.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kunglao9;
                }else if (radioButton12.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shangtsung9;
                }else if (radioButton15.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sindel9;
                }else if (radioButton16.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shaokahn9;
                }else if (radioButton17.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_goro9;
                }
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                if (radioButton2.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_scorpion10;
                }
                else if (radioButton1.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_subzero10;
                }
                else if (radioButton3.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_reptile10;
                }
                else if (radioButton4.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kitana10;
                }
                else if (radioButton5.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jade10;
                }
                else if (radioButton6.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_mileena10;
                }
                else if (radioButton7.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_baraka10;
                }
                else if (radioButton8.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_raiden10;
                }
                else if (radioButton9.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sonya10;
                }
                else if (radioButton10.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_johny10;
                }
                else if (radioButton11.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jax10;
                }
                else if (radioButton13.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_liukang10;
                }
                else if (radioButton14.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kunglao10;
                }
                else if (radioButton12.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shangtsung10;
                }
                else if (radioButton15.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sindel10;
                }
                else if (radioButton16.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shaokahn10;
                }
                else if (radioButton17.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_goro10;
                }
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                if (radioButton2.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_scorpion11;
                }
                else if (radioButton1.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_subzero11;
                }
                else if (radioButton3.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_repitile11;
                }
                else if (radioButton4.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kitana11;
                }
                else if (radioButton5.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jade11;
                }
                else if (radioButton6.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_mileena11;
                }
                else if (radioButton7.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_baraka11;
                }
                else if (radioButton8.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_raiden11;
                }
                else if (radioButton9.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sonya11;
                }
                else if (radioButton10.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_johnny11;
                }
                else if (radioButton11.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_jax11;
                }
                else if (radioButton13.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_luikang11;
                }
                else if (radioButton14.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_kunglao11;
                }
                else if (radioButton12.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shangtsung11;
                }
                else if (radioButton15.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_sindey11;
                }
                else if (radioButton16.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_shaokahn11;
                }
                else if (radioButton17.Checked)
                {
                    pictureBox3.Image = Properties.Resources.Cha_goro11;
                }
            }
        }
    }
}