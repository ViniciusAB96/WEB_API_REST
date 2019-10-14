﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_REST.Models
{
    public class UsuarioModel
    {
        private int codigo;
        private string nome;
        private string login;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }

        public string Login { get { return login; } set { login = value; } }

        public UsuarioModel ( int codigo, string nome, string login){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Login = login;       
        }
       
    }
}