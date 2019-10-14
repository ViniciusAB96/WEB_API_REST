using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WEB_API_REST.Models;

namespace WEB_API_REST.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModel> listUsuarios = new List<UsuarioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(UsuarioModel usuario)
        {
            listUsuarios.Add(usuario);
            return "Usuario cadastrado com sucesso. Parabéns!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(UsuarioModel usuario)
        {
            listUsuarios.Where(n => n.Codigo == usuario.Codigo).Select(s => { s.Codigo = usuario.Codigo;
                                                                                s.Login = usuario.Login;
                                                                                s.Nome = usuario.Nome;
                                                                                return s;}).ToList();
            return "Usuário alterado com sucesso.";
        }

        [AcceptVerbs("Delete")]
        [Route("ExcluirUsusrio/{codigo}")]

        public string ExcluirUsuario(int codigo)
        {
            UsuarioModel usuario = listUsuarios.Where(n => n.Codigo == codigo).Select(n => n).First();
            listUsuarios.Remove(usuario);
            return "Registro excluído com sucesso!!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public UsuarioModel ConsultarUsuarioPorCodigo(int codigo)
        {
            UsuarioModel usuario = listUsuarios.Where(n => n.Codigo == codigo).Select(n => n).FirstOrDefault();
            return usuario;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<UsuarioModel>ConsultarUsuarios()
        {
            CarregarUsuarios();
            return listUsuarios;
        }
        private void CarregarUsuarios()
        {
            listUsuarios.Clear();
            listUsuarios.Add(new UsuarioModel(1, "Vinícius de Andrade Barros", "082150366"));
            listUsuarios.Add(new UsuarioModel(2, "Jailton da Silva Alferhein", "080048944"));
        }

    }
}