using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AnimalClinicProject
{
    public class BaseInpc : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
