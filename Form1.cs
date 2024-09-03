using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public partial class Form1 : Form
    {

        public class Pessoa 
        {
            //prop pressionar TAB 2 vezes
            // Atributo é definido por
            //Acesso: public ou private
            //tipo de dados: string, int, bool...
            //nome do atributo: Nome, cpf, ...
            //Get/Set: leitura e gravação

            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DtNascimento { get; set; }

            //Criar um construtor para definir
            //um valor padrao para cada atributo
            //Construtor deve ter o nome da classe seguido dos parenteses
            public Pessoa()
            {
                Nome = "Desconhecido";
                CPF = "00000000000";
                DtNascimento = DateTime.Now;
            }

            //criação de um metodo que retorna uma mensagem de boas vindas
            //de acordo com o valor do atributo "Nome"
            public string GetBoasVindas()
            {
                return "Boas Vindas," + Nome;
            }

            //Criar uma propiedade somente leitura que ira retornar
            //a concatenação do cpf com o valor do atributo Nome
            public string CPFNome
            {
                get
                {
                    return CPF + "-" + Nome.ToUpper();
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        Pessoa pessoaBkp = new Pessoa();
        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Criar uma instancia da classe Pessoa
            //ou seja vamos alocar a classe em memoria
            Pessoa instancia = new Pessoa();


            // txtNome = nome atribuido nas propiedades do textBox, assim como txtCPF.
            instancia.Nome = txtNome.Text;
            instancia.CPF = txtCPF.Text;
            instancia.DtNascimento = dtpDtNascimento.Value;

            pessoaBkp = instancia; 
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            txtVisuNome.Text = pessoaBkp.Nome;
            txtVisuCPF.Text = pessoaBkp.CPF;
            txtVisuDtNascimento.Text = pessoaBkp.DtNascimento.ToShortDateString();

            lblBoasVindas.Text = pessoaBkp.GetBoasVindas();
            lblCPFNome.Text = pessoaBkp.CPFNome;
        }

    }
}
