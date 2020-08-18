using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoFinal.Model
{
    public class User : INotifyPropertyChanged
    {

        public class Id {
            [JsonProperty("$oid")]
            public string oid { get; set; }
        }

        public Id _id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string firstLastName { get; set; }
        public string secondLastName { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string identification { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
