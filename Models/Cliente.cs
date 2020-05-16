using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EFC_1.Models
{
    public class Cliente
    {

        public int Id{set;get;}
        
        public String Nombre{set;get;}
        public String Email{set;get;}
        public long Telefono{set;get;}
        public String Sexo{set;get;}
        public Cliente(){
            
        }
    }
}