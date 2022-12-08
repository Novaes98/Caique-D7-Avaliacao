using System;
using System.ComponentModel.DataAnnotations;

namespace Caique_D7_avaliacao.Data
{
    public class Register
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        internal static bool Any(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
