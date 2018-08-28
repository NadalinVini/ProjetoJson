using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Repositorio;

namespace Trabalho.Repositorio
{
    public class Banco
    {
        //Adiciona Imovel
        public int AdicionarImovel(string cat,
                                     string status,
                                     string faixa_area,
                                     string faixa_area_privada,
                                     string faixa_iptu,
                                     string faixa_area_condominio,
                                     bool flg_planta,
                                     bool flg_dependencia,
                                     bool flg_sacada,
                                     bool flg_portaria,
                                     bool flg_elevador,
                                     string churrasqueira,
                                     string faixa_dormitorios,
                                     string faixa_suites,
                                     string faixa_vagas,
                                     string faixa_banheiros,
                                     string faixa_valor_venda,
                                     string faixa_valor_aluguel,
                                     bool mostra_mapa
                                     )
        {
            TAB_Imovel imovel = new TAB_Imovel();
            imovel.Categoria = cat;
            imovel.Status_ = status;
            imovel.Faixa_Area = faixa_area;
            imovel.Faixa_Area_Privada = faixa_area_privada;
            imovel.Faixa_Area_Condominio = faixa_area_condominio;
            imovel.Flg_Planta = flg_planta;
            imovel.Flg_Dependencia = flg_dependencia;
            imovel.Flg_Sacada = flg_sacada;
            imovel.Flg_Portaria = flg_portaria;
            imovel.Flg_Elevador = flg_elevador;
            imovel.Churrasqueira = churrasqueira;
            imovel.Faixa_Dormintorios = faixa_dormitorios;
            imovel.Faixa_Suites = faixa_suites;
            imovel.Faixa_Vagas = faixa_vagas;
            imovel.Faixa_Banheiros = faixa_banheiros;
            imovel.Faixa_Valor_Venda = faixa_valor_venda;
            imovel.Faixa_Valor_Aluguel = faixa_valor_aluguel;
            imovel.Flg_Mostra_mapa = mostra_mapa;
            imovel.Faixa_Preco_IPTU = faixa_iptu;

            TrabalhoEFEntities ef = new TrabalhoEFEntities();
            ef.TAB_Imovel.Add(imovel);

            ef.SaveChanges();
            
                int qtd = Convert.ToInt32((from p in ef.TAB_Imovel select p.Idf_Imovel).Max());

                return qtd;
            }
        
        //Adiciona Tempo
        public int RandomNumber()
        {
            Random random = new Random();
            var ano = random.Next(1900, 2019);

            TrabalhoEFEntities ef = new TrabalhoEFEntities();

            TAB_Tempo tempo = new TAB_Tempo();
            tempo.Ano_Construcao = ano;
            ef.TAB_Tempo.Add(tempo);

            ef.SaveChanges();

            int qtd = Convert.ToInt32((from p in ef.TAB_Tempo select p.Idf_Tempo).Max());

            return qtd;
            
        }

        public void AdicionarFato(string des_bairro, int tempo, int imovel, string padrao)
        {
            TrabalhoEFEntities ef = new TrabalhoEFEntities();

            TAB_Fato fato = new TAB_Fato();
            Banco_Regiao br = new Banco_Regiao();

            fato.Idf_Tempo = tempo;
            fato.Idf_Imovel = imovel;
            fato.Idf_Bairro = br.BuscarBairroporId(des_bairro);
            fato.Padrao = padrao;

            ef.TAB_Fato.Add(fato);

            ef.SaveChanges();
        }
    }
}
