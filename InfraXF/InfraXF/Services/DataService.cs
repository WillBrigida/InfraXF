using InfraXF.Models;
using InfraXF.Services.Armazenamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Services
{
    public class DataService
    {
        public Resposta InserirUsuario( Usuario usuario)
        {
            try
            {
                using (var da = new DataAcess()) 
                {
                    da.Inserir(usuario);
                }
                return new Resposta
                {
                    IsSuccess = true,
                    Mensagem = "Usuario inserido com sucesso",
                    Resultado = usuario
                    
                };
            }
            catch (Exception ex)
            {
                return new Resposta
                {
                    IsSuccess = false,
                    Mensagem = ex.Message,
                };
            }
        }
    }
}
