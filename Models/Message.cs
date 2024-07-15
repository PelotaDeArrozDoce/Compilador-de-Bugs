using Microsoft.AspNetCore.Mvc;

namespace Compilador_de_Bugs.Models
{  
        public class Message
        {
            public required string Content { get; set; }
            public string Nome { get; set; } = string.Empty;
            public string Sobrenome { get; set; } = string.Empty;
            public required string Email { get; set; }
            public required string Phone { get; set; }
            
        }
}