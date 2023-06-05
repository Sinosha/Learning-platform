using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Interface
{
    public interface IEncrypt
    {
        public string HashPassword(string password, string salt);
    }
}
