using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Common.Interfaces
{
    public interface IBusiness : IDisposable
    {
        bool Login(string user, string password);
        bool LostPassword(string email);
        bool Register(string user, string email, string password);
    }
}
