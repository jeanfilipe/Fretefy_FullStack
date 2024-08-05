using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class UF
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
