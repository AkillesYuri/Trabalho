using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        List<Pessoa> lista = new List<Pessoa>();
        
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void preencherdatagriedview()
        {
            dataGridView1.Rows.Clear();

            for(int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == 'F'? "Feminino" : "Masculino",
                    lista[i].CPF,
                    lista[i].RG,
                    lista[i].NecessidadeEspeciais == false ? "Não" : "Sim"
                };

                dataGridView1.Rows.Add(nova_linha);
            }

        }

        private void limparcampos()
        {
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cmbSexo.Text = " ";
            if (rbSim.Checked)
            {
                rbSim.Checked = false;
            }
            else
            {
                rbNao.Checked = false;
            }
            mtxCPF.Clear();
            mtxRG.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            if (txtNome.Text != "" && cmbSexo.Text!="" && dtpDataNascimento.Text!=""&& mtxCPF.Text!="" && mtxRG.Text!="")
            {
                if (rbSim.Checked || rbNao.Checked)
                {

                        pessoa.Nome = txtNome.Text;
 
            

                        if(cmbSexo.SelectedIndex == 0)
                        {
                            pessoa.Sexo = 'M';
                        }
                        else
                        {
                            pessoa.Sexo = 'F';
                        }

                        pessoa.DataNascimento = dtpDataNascimento.Text;

                        if (rbSim.Checked)
                        {
                            pessoa.NecessidadeEspeciais = true;
                        }
                        if (rbNao.Checked)
                        {
                            pessoa.NecessidadeEspeciais = false;
                        }

                        pessoa.RG = mtxRG.Text;
                        pessoa.CPF = mtxCPF.Text;

                        lista.Add(pessoa);

                        preencherdatagriedview();
                        limparcampos();
                }
                else
                {
                    MessageBox.Show("Preencha todos os Campos");
                }


                }
            else
            {
                MessageBox.Show("Preencha todos os Campos");
            }

        }
            

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indicelinha = dataGridView1.CurrentRow.Index;

            lista.RemoveAt(indicelinha);

            limparcampos();

            dataGridView1.Rows.Clear();

            preencherdatagriedview();

            MessageBox.Show("Exclusão realizada");
        }
    }
}
