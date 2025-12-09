using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DungeonsNDragons_Character_Companion.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
    //private bool isBusy;
    private string title;

    // Indicates if App is active or not
    //public bool IsBusy
    //{
    //    get => isBusy; 
    //    set 
    //    {
    //        if(isBusy == value) 
    //            return;

    //        isBusy = value;
    //        OnPropertyChanged(nameof(IsBusy));
    //        OnPropertyChanged(nameof(IsNotBusy));
    //    }
    //}

    //public bool IsNotBusy => !IsBusy;

    public string Title
    {
        get => title;
        set
        {
            if (title == value)
                return;

            title = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName]string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}