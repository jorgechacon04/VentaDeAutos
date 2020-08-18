using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Dto
{
    public class TokenTransporter
    {
        public string Token { get; set; }

        private readonly static TokenTransporter _instance = new TokenTransporter();

        private TokenTransporter()
        {
        }

        public static TokenTransporter Instance
        {
            get
            {
                return _instance;
            }


        }
    }
}
