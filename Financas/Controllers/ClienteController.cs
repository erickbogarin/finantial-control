using Financas.DAO;
using Financas.Entidades;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Financas.Controllers
{
    public class ClienteController : ApiController
    {
        private UsuarioDAO usuarioDAO;
        
        public ClienteController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }
        
        // GET api/cliente
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.usuarioDAO.Lista());
        }
    }
}
