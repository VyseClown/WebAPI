using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class LoginRepositorio
    {
        public Login logar(string login, string senha)
        {
            Login log = null;
            using (dbAppEntities db =
                new dbAppEntities())
            {
                log = (from l in db.Login
                       where l.Login1 == login && l.Senha == senha
                       select l).FirstOrDefault();
            }
            return log;
        }
    }
}
