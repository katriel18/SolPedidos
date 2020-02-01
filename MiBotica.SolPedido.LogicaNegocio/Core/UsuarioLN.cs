using MiBotica.SolPedidos.Entidades.Core;//----------
using MiBotica.SolPedidos.AccesoDatos.Core;//--------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiBotica.SolPedidos.Entidades.Base;//-----------------

namespace MiBotica.SolPedido.LogicaNegocio.Core
{
    public class UsuarioLN : BaseLN
    {
        public List<Usuario> ListaUsuarios()
        {
            try
            {
                return new UsuarioDA().ListaUsuarios();//----------------
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
