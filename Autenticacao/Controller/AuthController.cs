using Cantina.Data;
using Cantina.Models;
using System;
using System.Linq;

namespace Autenticacao.Controllers
{
    public static class AuthController
    {
        // Método para autenticar um usuário
        public static bool Authenticate(string username, int NIF)
        {
            using (var context = new CantinaContext())
            {
                // Verifica se existe um funcionário com o username e NIF informados
                var funcionario = context.Funcionarios.FirstOrDefault(f => f.Username == username && f.NIF == NIF);

                if (funcionario != null)
                {
                    return true; // Retorna verdadeiro se autenticado com sucesso
                }
                else
                {
                    return false; // Retorna falso se autenticação falhou
                }
            }
        }
    }
}
