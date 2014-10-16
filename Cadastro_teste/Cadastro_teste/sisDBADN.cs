using System;
using System.Collections.Generic;//tem o list
using System.Collections;//array list
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cadastro_teste
{
    class sisDBADN
    {
        private const string _strCon = @"Data Source=MISA-PC\SQLEXPRESS;Initial Catalog=CRUD_Alunos;Integrated Security=True";
        private string vsql = "";
        SqlConnection objCon = null;

        #region "Métodos de Conexão com o Banco"
       
        private bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)//se não fechou, feche e tira da memoria
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
        #endregion

        #region "Métodos de Execução de SQL"

        public bool Insert(ArrayList p_arrInsert)//fazendo isso n tem que dizer as variaveis
        {

            vsql = " INSERT INTO CRUD_ALUNOS ([NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL],"+
            "[CIDADE],[UF],[NOME_PAI],[NOME_MAE])VALUES (@NOME,@IDADE, @ENDERECO, @TELEFONE, @EMAIL,@CIDADE, @UF, @NOME_PAI, @NOME_MAE)";

            SqlCommand objcmd = null;//vai tentar criar o objcmd 
            //se conseguir vai jogar pra dentro
            if(this.conectar())
            {
                try// vai tentar executar. se conseguir, finaliza.
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrInsert[0]));//pq todo arreia começa em zero
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_arrInsert[1]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_arrInsert[2]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrInsert[3]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_arrInsert[4]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrInsert[5]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_arrInsert[6]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_arrInsert[7]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_MAE", p_arrInsert[8]));

                    objcmd.ExecuteNonQuery();//execute e não consulte

                    return true;//tira o "erro" que mostrava no public boll isert
                }
                catch(SqlException sqlerr)//não conseguiu. captura erro e preenche a variável e enviada pelo throw na tela
                {
                    throw sqlerr;

                }
                finally
                {
                    this.desconectar();
                }
                
            }
            else
            {
                return false;
            }



        }

        public bool Update(ArrayList p_arrUpdate)
        {
            vsql = "UPDATE CRUD_ALUNOS SET NOME = @NOME, IDADE = @IDADE, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, EMAIL = @EMAIL,"+
            "CIDADE = @CIDADE, UF = @UF, NOME_PAI = @NOME_PAI, NOME_MAE = @NOME_MAE WHERE ID_ALUNO = @ID_ALUNO";
            
            SqlCommand objcmd = null;//vai tentar criar o objcmd 
            //se conseguir vai jogar pra dentro
            if (this.conectar())
            {
                try// vai tentar executar. se conseguir, finaliza.
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@ID_ALUNO", p_arrUpdate[0]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrUpdate[1]));
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_arrUpdate[2]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_arrUpdate[3]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrUpdate[4]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_arrUpdate[5]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrUpdate[6]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_arrUpdate[7]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_arrUpdate[8]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_MAE", p_arrUpdate[9]));

                    objcmd.ExecuteNonQuery();//execute e não consulte

                    return true;//tira o "erro" que mostrava no public boll UPDATE
                }
                catch (SqlException sqlerr)//não conseguiu. captura erro e preenche a variável e enviada pelo throw na tela
                {
                    throw sqlerr;

                }
                finally
                {
                    this.desconectar();
                }

            }
            else
            {
                return false;
            }

        }

        public bool Delete(int id_aluno)
        {
            vsql = "DELETE FROM CRUD_ALUNOS WHERE ID_ALUNO = @ID_ALUNO";

            SqlCommand objcmd = null;
            
            if(this.conectar())
            {
                try// vai tentar executar. se conseguir, finaliza.
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@ID_ALUNO",id_aluno);
                    
                    objcmd.ExecuteNonQuery();//execute e não consulte

                    return true;//tira o "erro" que mostrava no public boll UPDATE
                }
                catch (SqlException sqlerr)//não conseguiu. captura erro e preenche a variável e enviada pelo throw na tela
                {
                    throw sqlerr;

                }
                finally
                {
                    this.desconectar();
                }

            }
            else
            {
                return false;
            }

        }
        #endregion

        #region "Métodos que ListaGrid e Faz Pesquisa"
        public DataTable ListaGrid()
        {

            vsql = "SELECT [ID_ALUNO] as Código, [NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS";// SE POR * ELE VAI INTERPRETAR COMO UM NOVO E TRABALHA LENTO 

            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;

                }
                finally
                {
                    this.desconectar();
                }

            }
            else
            {
                return null;
            }

            return null;
        }

        public DataTable Pesquisar(string sql, string param)
        {
            this.vsql = sql;

            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@VALOR", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;

                }
                finally
                {
                    this.desconectar();
                }

            }
            else
            {
                return null;
            }

            

            
        }
        #endregion
    
    }
}
