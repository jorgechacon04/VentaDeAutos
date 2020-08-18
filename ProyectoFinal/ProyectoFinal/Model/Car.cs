using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProyectoFinal.Model
{
    public class Car : INotifyPropertyChanged
    {
      
        public string user { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public string model { get; set; }
        public int km { get; set; }
        public string plate { get; set; }
        public int year { get; set; }
        public string transmission { get; set; }
        public string extras { get; set; }
        public string photos { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
