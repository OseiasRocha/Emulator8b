using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHLE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //botão COMPILE do help
        {
            MessageBox.Show("O botão COMPILE é responsável por traduzir o código escrito em uma linguágem que a máquina compreenda.");
        }

        private void button4_Click(object sender, EventArgs e) // botão RUN do help
        {
            MessageBox.Show("O botão RUN é responsável por executar o programa compilado anteriormente. " +
                "Diferente do CLOCK, ao pressionar esta tecla, o processador executa todas as linhas até que chegue no final da execcução " +
                "ou que seja solicitada sua parada por alguma instrução contida no programa.");
        }

        private void button3_Click(object sender, EventArgs e) // botão RESET do help
        {
            MessageBox.Show("O botão RESET é responsável por zerar todas as entradas e contadores para poder iniciar do ZERO o programa, " +
                "evitando que valores antigos estejam presentes quando for feita uma nova execução do programa.");
        }

        private void button2_Click(object sender, EventArgs e) // botão CLOCK do help
        {
            MessageBox.Show("O botão CLOCK é responsável por rodar o programa pausadamente, uma instrução por vez. " +
                "Cada vez que o botão CLOCK é pressionado, o processador executa uma linha do programa.");
        }

        private void button5_Click(object sender, EventArgs e) // botão COMANDOS
        {
            MessageBox.Show("MOV RXX, y\n" +
                            "   -> MOVE - Coloca o valor y no registrador XX.\n\n" +
                            "STO RXX\n" +
                            "   -> STORE ACCUMULATOR - Passa o valor do registrador XX \n" +
                            " para o acumulador.\n\n" +
                            "INC RXX\n" +
                            "   -> INCREMENTA - Soma 1 para o valor contido no registrador XX.\n\n" +
                            "DEC RXX\n" +
                            "   -> DECREMENTA - Subtrai 1 do valor contido no registrador XX.\n\n" +
                            "CMP RXX, RYY\n" +
                            "   -> COMPARE - Compara o valor do registrador XX com o YY.\n\n" +
                            "JNZ A\n" +
                            "   -> JUMP NOT ZERO - Salta para um local determinado se\n" +
                            " o sinalizador ZERO estiver desmarcado.\n\n" +
                            "OUT OYY, RXX\n" +
                            "   -> SAIDA - Coloca o valor do registrador XX na porta OYY.\n\n" +
                            "HLT\n" +
                            "   -> HALT - Instrução que interrompe o funionamento do processador.\n");
        }
    }
}
