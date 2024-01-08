using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;

namespace prjListaLivros.logica
{
    internal class ExemplarLogica
    {
        private Banco Banco = null;

        public ExemplarLogica()
        {
            Banco = new Banco();
        }

        public List<Exemplar> ListarPorCodigoLivro(int codigoLivro)
        {
            List<Exemplar> exemplares = new List<Exemplar>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT e.cd_exemplar, e.ic_fixo, e.cd_rfId ,l.*,
                (SELECT IF((SELECT COUNT(*) FROM emprestimo e2 WHERE cd_exemplar = e2.cd_exemplar) = 0, 'false', (SELECT IF(COUNT(*) <> 0, 'true', 'false') FROM emprestimo WHERE cd_exemplar = e.cd_exemplar AND CURDATE() <= dt_devolucao_estimada AND dt_devolucao IS NULL))) as ic_emprestado,
                e.cd_livro
                FROM exemplar e 
                JOIN localizacao l ON l.cd_localizacao = e.cd_localizacao
                WHERE e.cd_livro = " + codigoLivro);

            while (dados.Read())
            {
                Exemplar exemplar = new Exemplar(
                        int.Parse(dados[0].ToString()),
                        bool.Parse(dados[1].ToString()),
                        dados[2].ToString(),
                        new Localizacao(int.Parse(dados[3].ToString()), dados[4].ToString(), null),
                        int.Parse(dados["cd_livro"].ToString())
                );
                exemplar.Emprestado = bool.Parse(dados["ic_emprestado"].ToString());
                exemplares.Add(exemplar);
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return exemplares;
        }

        public Exemplar BuscarPorCodigo(int codigoExemplar)
        {
            List<Exemplar> exemplares = new List<Exemplar>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT e.cd_exemplar, e.ic_fixo, e.cd_rfId ,l.*,
                (SELECT IF((SELECT COUNT(*) FROM emprestimo e2 WHERE cd_exemplar = e2.cd_exemplar) = 0, 'false', (SELECT IF(COUNT(*) <> 0, 'true', 'false') FROM emprestimo WHERE cd_exemplar = e.cd_exemplar AND CURDATE() <= dt_devolucao_estimada AND dt_devolucao IS NULL))) as ic_emprestado,
                e.cd_livro
                FROM exemplar e 
                JOIN localizacao l ON l.cd_localizacao = e.cd_localizacao
                WHERE e.cd_exemplar = " + codigoExemplar);

            if (dados.Read())
            {
                Exemplar exemplar = new Exemplar(
                        int.Parse(dados[0].ToString()),
                        bool.Parse(dados[1].ToString()),
                        dados[2].ToString(),
                        new Localizacao(int.Parse(dados[3].ToString()), dados[4].ToString(), null),
                        int.Parse(dados["cd_livro"].ToString())
                );
                exemplar.Emprestado = bool.Parse(dados["ic_emprestado"].ToString());    
                if (!dados.IsClosed) dados.Close();
                Banco.Desconectar();
                return exemplar;
            }
            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return null;
        }

        public Exemplar BuscarPorRfid(string rfid)
        {
            List<Exemplar> exemplares = new List<Exemplar>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT e.cd_exemplar, e.ic_fixo, e.cd_rfId ,l.*,
                (SELECT IF((SELECT COUNT(*) FROM emprestimo e2 WHERE cd_exemplar = e2.cd_exemplar) = 0, 'false', (SELECT IF(COUNT(*) <> 0, 'true', 'false') FROM emprestimo WHERE cd_exemplar = e.cd_exemplar AND CURDATE() <= dt_devolucao_estimada AND dt_devolucao IS NULL))) as ic_emprestado,
                e.cd_livro
                FROM exemplar e 
                JOIN localizacao l ON l.cd_localizacao = e.cd_localizacao
                WHERE e.cd_rfid = '" + rfid + "'");

            if (dados.Read())
            {
                Exemplar exemplar = new Exemplar(
                        int.Parse(dados[0].ToString()),
                        bool.Parse(dados[1].ToString()),
                        dados[2].ToString(),
                        new Localizacao(int.Parse(dados[3].ToString()), dados[4].ToString(), null),
                        int.Parse(dados["cd_livro"].ToString())
                );
                exemplar.Emprestado = bool.Parse(dados["ic_emprestado"].ToString());
                if (!dados.IsClosed) dados.Close();
                Banco.Desconectar();
                return exemplar;
            }
            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return null;
        }
    }
}
