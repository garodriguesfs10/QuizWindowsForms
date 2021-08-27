using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizWinForms
{
    public partial class FormPerguntas : Form
    {
        public FormPerguntas()
        {
            InitializeComponent();
            progressBar1.Hide();
            btnReiniciarQuiz.Hide();
            MudarPerguntaAtual(1);
        }

        static private int perguntaAtual = 1;
        private int acertos;
        private int erros;
        const int totalDeQuestoes = 5;
        private List<int> listaErros = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
             var radioSelecionado = groupBox1.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!radioSelecionado)
            {
                MessageBox.Show("Selecione uma pergunta", "Ops...");
                return;
            }
            else
            {                
                ConferirResposta(perguntaAtual);
                if (perguntaAtual == totalDeQuestoes) return;
                perguntaAtual += 1;
                MudarPerguntaAtual(perguntaAtual);  
            }
        }

      

        public void ConferirResposta(int pergunta)
        {
            var radioSelecionado = Convert.ToInt32(groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag);
            switch (pergunta)
            {
                case 1:
                    var p1 = (Convert.ToInt32(respostasCertas.Primeira) == radioSelecionado) ? acertos++ : Errou(pergunta);
                    break;
                case 2:
                    var p2 = (Convert.ToInt32(respostasCertas.Segunda) == radioSelecionado) ? acertos++ : Errou(pergunta);
                    break;
                case 3:
                    var p3 = (Convert.ToInt32(respostasCertas.Terceira) == radioSelecionado) ? acertos++ : Errou(pergunta);
                    break;
                case 4:
                    var p4 = (Convert.ToInt32(respostasCertas.Quarta) == radioSelecionado) ? acertos++ : Errou(pergunta);
                    break;
                case 5:
                    var p5 = (Convert.ToInt32(respostasCertas.Quinta) == radioSelecionado) ? acertos++ : Errou(pergunta);                   
                    FinalizarQuiz();
                    break;
                default:
                    break;
            }
            
        }

        public int Errou(int pergunta)
        {
            erros++;
            listaErros.Add(pergunta);
            return pergunta;
        }
        public async void FinalizarQuiz()
        {
                    
            btnProximo.Enabled = false;
            AtivarRadios(false);
            progressBar1.Show();
            for (int i = 0; i < 10; i++)
            {
                progressBar1.Value += 10;
                await Task.Delay(500);
            }
            progressBar1.Hide();

            var mensagem = $"Parabéns! Você acertou {acertos} pergunta(s) e errou {erros} pergunta(s)! " +
                           $"\nPorcentagem: {acertos * 100 / totalDeQuestoes}%";
            if(erros > 0)
            {
                mensagem += $"\nVocê errou a(s) pergunta(s): {String.Join(",",listaErros)}";
            }
                     
            MessageBox.Show(mensagem, "Quiz concluído!");
            btnReiniciarQuiz.Show();
        }

        public enum respostasCertas
        {
            Primeira = 3,
            Segunda = 1,
            Terceira = 2,
            Quarta = 4,
            Quinta = 3
        }
        public void MudarPerguntaAtual(int perguntaAtual)
        {
            var radioChecked = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (radioChecked != null)
            {
                radioChecked.Checked = false;
            }
            switch (perguntaAtual)
            {
                case 1:
                    lblPergunta.Text = "O que é o Entity Framework Core?";
                    radioOp1.Text = "1 - Banco de dados relacional";
                    radioOp2.Text = "2 - Microsserviço";
                    radioOp3.Text = "3 - ORM";
                    radioOp4.Text = "4 - Método de autenticação";
                    break;
                case 2:
                    lblPergunta.Text = "O que a visibilidade define em POO?";
                    radioOp1.Text = "1 - Define quem pode alterar cada dado, em três principais níveis: Public, Private e Protected";
                    radioOp2.Text = "2 - Tudo em geral que possui atributos, comportamentos e estado";
                    radioOp3.Text = "3 - É um molde de um objeto";
                    radioOp4.Text = "4 - Nenhuma das alternativas";
                    break;
                case 3:
                    lblPergunta.Text = "Quais são os dois tipos por valor que aceitam valores decimais em .NET?";
                    radioOp1.Text = "1 - String e float";
                    radioOp2.Text = "2 - Double e float";
                    radioOp3.Text = "3 - Char e string";
                    radioOp4.Text = "4 - Int e float";
                    break;                  
                case 4:
                    lblPergunta.Text = "O que um código C# gera ao ser compilado no comando \"dotnet build\"?";
                    radioOp1.Text = "1 - Código JIT";
                    radioOp2.Text = "2 - Código compilado em Linguagem de Máquina";
                    radioOp3.Text = "3 - Código CLR";
                    radioOp4.Text = "4 - Código compilado em Linguagem Intermediária";
                    break;             
                case 5:
                    btnProximo.Text = "Finalizar Quiz";
                    lblPergunta.Text = "Quais os quatro pilares da POO?";
                    radioOp1.Text = "1 - Abdução, Cápsula, Hierarquia e Polimorfismo";
                    radioOp2.Text = "2 - Abs, Caps, Herança e Polimorfismo";
                    radioOp3.Text = "3 - Abstração, Encapsulamento , Herança e Polimorfismo";
                    radioOp4.Text = "4 - Abstração, Capsulamento, Herdismo e Polimorfo"; 
                    break;
                default:
                    break;
            }
        }

        public void AtivarRadios(bool condicao)
        {
            var radios = groupBox1.Controls.OfType<RadioButton>();
            foreach (var item in radios)
            {
                item.Enabled = condicao;
            }
        }
        private void btnReiniciarQuiz_Click(object sender, EventArgs e)
        {
            ReiniciarQuiz();
        }

        public void ReiniciarQuiz()
        {
            btnReiniciarQuiz.Hide();
            perguntaAtual = 1;
            erros = 0;
            acertos = 0;
            listaErros.Clear();
            AtivarRadios(true);
            progressBar1.Value = 0;
            btnProximo.Text = "Avançar";
            btnProximo.Enabled = true;
            progressBar1.Hide();
            MudarPerguntaAtual(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReiniciarQuiz();
            this.Dispose();
        }
    }
}
