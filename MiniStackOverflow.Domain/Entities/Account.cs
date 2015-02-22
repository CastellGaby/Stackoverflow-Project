﻿using System;

namespace MiniStackOverflow.Domain.Entities
{
    public class Account : IEntity
    {
        public Guid Id { get; set; }

        public Account()
        {
            Id = Guid.NewGuid();
        }
        //Atributos
        public string E_mail { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        
        public string Age { get; set; }
        public string DateJoin { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Confirm { get; set; }

    }
}