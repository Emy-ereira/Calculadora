using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2._0
{
    public partial class Form1 : Form

    {
        double resultado;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Vetor com as operações que entrarão no comboBox
            string[] operacao = new string[4] { "+", "-", "x", "/" };
           
            // Inserindo as operações dentro do comboBox
            foreach (String op in operacao)
            {
                comboBoxOperacao.Items.Add(op.ToString());

            }


        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Verifica se os números inseridos são numéricos
            // tenta converter o txtValor1 em double e armazena na variável valor1 || tenta converter o txtValor2 em double e armazena na variável valor2
            // o código verifica se as strings nos campos de texto txtValor1 e txtValor2 podem ser convertidas em números double, se a conversão falhar é exibida uma menssagem de erro
            if (!double.TryParse(txtValor1.Text, out double valor1) || !double.TryParse(txtValor2.Text, out double valor2))
            {
                MessageBox.Show("Os valores inseridos devem ser numéricos.");
                return;
            }

            // Verifica se o divisor é diferente de zero
            // se o divisor for 0, a menssagem de erro é disparada
            if (comboBoxOperacao.SelectedItem.ToString() == "/" && valor2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero.");
                return;
            }

            

            
    

            // o selecteIndex permite que eu acesse os itens do comboBox pelo indice
            switch (comboBoxOperacao.SelectedIndex)
            {
                // se o indice for 0 ou seja o "+"
                case 0:
                    resultado = valor1 + valor2;

                    break;
                // se o indice for 1 ou seja o "-"
                case 1:
                    resultado = valor1 - valor2;
       
                    break;
                case 2:
                    // se o indice for 2 ou seja o "x"
                    resultado = valor1 * valor2;
                    
                    break;
                case 3:
                    // se o indice for 3 ou seja a "/"
                    resultado = valor1 / valor2;
                   
                    break;

            }
            // sendo uma das condições satisfeitas, eu exibo no meu lblResultado o resultado da operação
            // o resultado entra convertido em string pois o lblResultado é um campo do tipo que aceita somente texto

            lblResultado.Text = resultado.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
