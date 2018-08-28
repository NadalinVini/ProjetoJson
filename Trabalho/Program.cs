using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Repositorio;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            Banco_Regiao br = new Banco_Regiao();

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\imobiliaria.json");

            var modelo = JsonConvert.DeserializeObject<List<Modelo.Modelo>>(json);

            foreach (var obj in modelo.ToList())
            {              
                //Tratando de dados do Tipo Faixa 

                #region Faixa Area Total
                //Verificando a faixa da area total do imovel
                var areat = Convert.ToDecimal(obj.area_total);
                var areatot = string.Empty;

                if (!String.IsNullOrEmpty(obj.area_total))
                    if (areat > 0 && areat <= 40)
                {
                    areatot = "Entre 0 - 40 metros";
                }
                else if (areat > 40 && areat <= 70)
                {
                    areatot = "Entre 41 - 70 metros";
                }
                else if (areat > 71 && areat <= 110)
                {
                    areatot = "Entre 71 - 110 metros";
                }
                else
                    areatot = "Acima de 111 metros";
                #endregion
                
                #region Faixa Area Privada
                //Verificando a faixa da area privada do imovel
                var areap = Convert.ToDecimal(obj.area_privativa);
                var areapri = string.Empty;

                if (!String.IsNullOrEmpty(obj.area_privativa))
                    if (areap > 0 && areap <= 40)
                {
                    areapri = "Entre 0 - 40 metros";
                }
                else if (areap > 40 && areap <= 70)
                {
                    areapri = "Entre 41 - 70 metros";
                }
                else if (areap > 71 && areap <= 110)
                {
                    areapri = "Entre 71 - 110 metros";
                }
                else
                    areapri = "Acima de 111 metros";
                #endregion

                #region Faixa Preço IPTU
                //Verificando a faixa de preço do IPTU do imovel
                var iptu = Convert.ToDecimal(obj.iptu);
                var fiptu = string.Empty;

                if (!String.IsNullOrEmpty(obj.iptu))
                    if (iptu > 0 && iptu <= 600)
                {
                    fiptu = "Entre 0 - 600 valores";
                }
                else if (iptu > 600 && iptu <= 1200)
                {
                    fiptu = "Entre 601 - 1200 valores";
                }
                else if (iptu > 1200 && iptu <= 1800)
                {
                    fiptu = "Entre 1201 - 1800 valores";
                }
                else
                    fiptu = "Acima de 1801 valores";

                #endregion

                #region Faixa Condominio
                //Verificando a faixa de condominio do imovel
                var cond = Convert.ToDecimal(obj.condominio);
                var condo = string.Empty;

                if (!String.IsNullOrEmpty(obj.condominio))
                {
                    if (cond > 0 && cond <= 100)
                    {
                        condo = "Entre 0 - 100 metros";
                    }
                    else if (cond > 100 && cond <= 150)
                    {
                        condo = "Entre 101 - 150 metros";
                    }
                    else if (cond > 151 && cond <= 200)
                    {
                        condo = "Entre 151 - 200 metros";
                    }
                    else
                    {
                        condo = "Acima de 201 metros";
                    }
                }
                #endregion

                #region Faixa Dormitorios
                //Verificando a faixa de dormitorios do imovel
                var dorm = Convert.ToInt32(obj.dormitorios);
                var torio = string.Empty;

                if (!String.IsNullOrEmpty(obj.dormitorios))
                {
                    if (dorm > 0 && dorm <= 2)
                    {
                        torio = "Entre 0 - 2 dormitorios";
                    }
                    else if (dorm > 2 && dorm <= 4)
                    {
                        torio = "Entre 3 - 4" +
                            " dormitorios";
                    }                    
                    else
                    {
                        torio = "Acima de 5 dormitorios";
                    }
                }
                #endregion

                #region Faixa Suites
                //Verificando a faixa de suites do imovel
                var suit = Convert.ToInt32(obj.suites);
                var suites = string.Empty;

                if (!String.IsNullOrEmpty(obj.suites))
                {
                    if (suit > 0 && suit <= 2)
                    {
                        suites = "Entre 0 - 2 suites";
                    }
                    else if (suit > 2 && suit <= 4)
                    {
                        suites = "Entre 3 - 4 suites";
                    }
                    else
                    {
                        suites = "Acima de 5 suites";
                    }
                }
                #endregion

                #region Faixa Vagas
                //Verificando a faixa de vagas do imovel
                var vagas = Convert.ToInt32(obj.vagas);
                var carros = string.Empty;

                if (!String.IsNullOrEmpty(obj.vagas))
                {
                    if (vagas > 0 && vagas <= 2)
                    {
                        carros = "Entre 0 - 2 vagas";
                    }
                    else if (vagas > 2 && vagas <= 4)
                    {
                        carros = "Entre 3 - 4 vagas";
                    }
                    else
                    {
                        carros = "Acima de 5 vagas";
                    }
                }
                #endregion

                #region Faixa Banheiros
                //Verificando a faixa de banheiros do imovel
                var banh = Convert.ToInt32(obj.banheiros);
                var eirros = string.Empty;

                if (!String.IsNullOrEmpty(obj.banheiros))
                {
                    if (banh > 0 && banh <= 2)
                    {
                        eirros = "Entre 0 - 2 banheiros";
                    }
                    else if (banh > 2 && banh <= 4)
                    {
                        eirros = "Entre 3 - 4 banheiros";
                    }
                    else
                    {
                        eirros = "Acima de 5 banheiros";
                    }
                }
                #endregion

                #region Faixa Valor Venda
                //Verificando a faixa do valor de venda do imovel
                var valor = Convert.ToDecimal(obj.valor_venda);
                var venda = string.Empty;
                var padrao = string.Empty;

                if (!String.IsNullOrEmpty(obj.valor_venda))
                    if (valor > 0 && valor <= 50000)
                {
                    venda = "Entre 0 - 50.000 valores";
                        padrao = "Básico";
                }
                else if (valor > 50000 && valor <= 125000)
                {
                    venda = "Entre 50.001" +
                        " - 125.000 valores";
                        padrao = "Médio";
                }
                else if (valor > 125000 && valor <= 200000)
                {
                    venda = "Entre 125.001 - 200.000 valores";
                        padrao = "Classe A";
                }

                else
                    venda = "Acima de 200.001 valores";
                padrao = "Alta Classe";
                #endregion

                #region Faixa Valor Aluguel
                //Verificando a faixa da area privada do imovel
                var aluguel = Convert.ToDecimal(obj.valor_aluguel);
                var aluguelx = string.Empty;

                if (!String.IsNullOrEmpty(obj.valor_aluguel))
                { 
                    if (aluguel > 0 && aluguel <= 1000)
                {
                    aluguelx = "Entre 0 - 1.000 valores";
                }
                else if (aluguel > 1000 && aluguel <= 1500)
                {
                    aluguelx = "Entre 1001" +" - 1.500 valores";
                }
                else if (aluguel > 1500 && aluguel <= 2750)
                {
                    aluguelx = "Entre 1.501 - 2.750 valores";
                }
                else
                    aluguelx = "Acima de 2.751 valores";
                }
                #endregion



                #region Métodos de Validação --Snow Flake

                //Validando se Estado ja existe

                var uf = br.BuscarEstado(obj.uf);
                var ufest = obj.uf;

                if(uf == 0)
                {
                    br.AdicionaEstado(ufest);
                }

                //Validando se Cidade ja existe

                var cid = br.BuscaCidade(obj.cidade);
                var cida = obj.cidade;

                if(cid == 0)
                {
                    br.AdicionaCidade(obj.cidade, obj.uf);
                }

                //Validando se Bairro ja existe

                var bai = br.BuscarBairro(obj.bairro);
                var bair = obj.bairro;
                var cep = Convert.ToInt32(obj.cep.Substring(0, 5));

                if(bai == 0)
                {
                    br.AdicionaBairro(obj.cidade, bair, cep);
                }

                #endregion


                #region Métodos de Inserção

                #region Adicionando Imovel
                //Metodo para inserir Imovel no Banco
              var idImovel = banco.AdicionarImovel(obj.categoria != null ? obj.categoria : null,
                                       obj.status != null ? obj.status : null,
                                       areatot == "" ? null : areatot,
                                       areapri == "" ? null : areapri,
                                       fiptu == "" ? null : fiptu,
                                       condo == "" ? null : condo,
                                       obj.planta.Contains("SIM") ? true : false,
                                       obj.dependencia.Contains("SIM") ? true : false,
                                       obj.sacada.Contains("SIM") ? true : false,
                                       obj.portaria.Contains("SIM") ? true : false,
                                       obj.elevador.Contains("SIM") ? true : false,
                                       obj.churrasqueira != null ? obj.churrasqueira : null,
                                       torio == "" ? null : torio,
                                       suites == "" ? null : suites,
                                       carros == "" ? null : carros,
                                       eirros == "" ? null : eirros,
                                       venda == "" ? null : venda,
                                       aluguelx == "" ? null : aluguelx,
                                       obj.mostrar_mapa.Contains("SIM") ? true : false
                                       );
                #endregion

                #region Tempo
                var ano = banco.RandomNumber();
                #endregion

                #region Fato

                banco.AdicionarFato(obj.bairro, ano, idImovel, padrao);

                #endregion

                #endregion
            }
        }
    }
}
