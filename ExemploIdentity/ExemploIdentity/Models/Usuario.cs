using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace ExemploIdentity.Models
{
    public class Usuario : IUser<string>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }

    public class Teste
    {
        public void Teste1()
        {
            var usuario = new Usuario { Id = "001", UserName = "Maria" };
            var usuarioStore = new UsuarioStore();
            var gerenciador = new UserManager<Usuario>(usuarioStore);
            var resultado = gerenciador.Create(usuario);

            if (resultado.Succeeded)
            {
                //OK
            }
        }
    }


    public class UsuarioStore : IUserStore<Usuario>
    {
        public Task CreateAsync(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Usuario user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario user)
        {
            throw new NotImplementedException();
        }
    }

}