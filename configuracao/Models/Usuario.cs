﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public  string NomeUsuario { get; set; } 
        
        public int Senha { get; set; }

        public string Email { get; set; }   

        public string  CPF { get; set; }
        public bool Ativo { get; set; }

       public  List<GrupoUsuario> GrupoUsuarios { get; set; }




    }
}
