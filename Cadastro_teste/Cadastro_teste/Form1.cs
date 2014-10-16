using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_teste
{
    public partial class frm_CRUD : Form
    {
        public frm_CRUD()
        {
            InitializeComponent();
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbTime.Text = "Data: " + dataHora.ToShortDateString() + "  Hora: " + dataHora.ToLongTimeString();
        }

        private void frm_CRUD_Load(object sender, EventArgs e) 
        {
            timer1_Tick(e, e);
           // sisDBADN test = new sisDBADN();//carrega o formularia e testa se a conexao esta funcionando

           // if(test.conectar())
            //{
            //    MessageBox.Show("Conectou.");
           // }
            //else
            //{
            //    MessageBox.Show("Não Conectou.");
           // }
           // 

        } //janela toda
                                      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();

            ArrayList arr = new ArrayList();

           try
           {
                arr.Add(tbNomeCad.Text);
                arr.Add(tbIdadeCad.Text);
                arr.Add(tbEnderecoCad.Text);
                arr.Add(tbTelefoneCad.Text);
                arr.Add(tbEmailCad.Text);
                arr.Add(cbCidadeCad.Text);
                arr.Add(cbUfCad.Text);
                arr.Add(tbCadNome_Pai.Text);
                arr.Add(tbCadNome_Mae.Text);

                if (obj.Insert(arr))
                {
                    MessageBox.Show("Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Aluno!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception erro)
                {
                MessageBox.Show(erro + "Erro Ocorrido");
                }
        } 

        private void toolStripButton2_Click(object sender, EventArgs e)//atulizar
        {
            sisDBADN obj = new sisDBADN();

            ArrayList arr = new ArrayList();

            arr.Add(tbEditCodigo.Text);
            arr.Add(tbEditNome.Text); 
            arr.Add(tbEditIdade.Text);
            arr.Add(tbEditEndereco.Text);
            arr.Add(tbEditTelefone.Text);
            arr.Add(tbEditEmail.Text);
            arr.Add(cbEditCidade.Text);
            arr.Add(cbEditUF.Text);
            arr.Add(tbEditPai.Text);
            arr.Add(tbEditMae.Text);


            if (obj.Update(arr))
            {
                MessageBox.Show("Atualizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage2_Enter(e, e);
            }
            else
            {
                MessageBox.Show("Não Atualizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();

            int codAluno = int.Parse(tbExcluir.Text);//Convert.ToInt16

            if (obj.Delete(codAluno))
            {
                MessageBox.Show("Excluido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage3_Enter(e, e);//mostra mensagem e link com o metotodo tabpag3 enter e atualiza
            }
            else
            {
                MessageBox.Show("Não foi Excluido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();
            cbUfCad.DataSource = obj.listaUF();
            cbUfCad.DisplayMember = "UF";
        } 

        private void tabPage2_Enter(object sender, EventArgs e) 
        {
            sisDBADN obj = new sisDBADN();
            cbEditUF.DataSource = obj.listaUF();
            dtEditar.DataSource = obj.ListaGrid();



        }

        private void tabPage3_Enter(object sender, EventArgs e) 
        {
            sisDBADN obj = new sisDBADN();
            dtExcluir.DataSource = obj.ListaGrid();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();
            string sql;

            if(rbPorNome.Checked)
            {
                sql = "SELECT [NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS WHERE NOME LIKE @VALOR"; //like diz que vc pode pegar partes do nome pra encontrar o que deseja
                dgPesquisar.DataSource = obj.Pesquisar(sql, "%" + tbPesquisar.Text + "%");//busca pela letra que tiver
                
            }
            else
            {
                sql = "SELECT [ID_ALUNO] as Código, [NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS WHERE ID_ALUNO = @VALOR"; //like diz que vc pode pegar partes do nome pra encontrar o que deseja
                dgPesquisar.DataSource = obj.Pesquisar(sql, tbPesquisar.Text);//busca pela letra que tiver
                
            }
        }

        private void dtExcluir_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void dtAdicionar_Enter(object sender, EventArgs e)
        {

        }

        private void cbUfCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();
            cbCidadeCad.DataSource = obj.listaCidade(cbUfCad.Text);
            cbCidadeCad.DisplayMember = "NOME";
        }

        private void cbEditUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisDBADN obj = new sisDBADN();
            cbEditCidade.DataSource = obj.listaCidade(cbEditUF.Text);
            cbEditCidade.DisplayMember = "NOME";
        }

        
    }
}
