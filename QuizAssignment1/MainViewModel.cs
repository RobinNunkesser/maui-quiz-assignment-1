using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace QuizAssignment1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly List<(string, bool)> questions =
            new List<(string, bool)> {
            ("Das Videospiel Donkey Kong sollte ursprünglich Popeye als Hauptfigur haben.", true),
            ("Die Farbe Orange wurde nach der Frucht benannt.", true),
            ("In der griechischen Mythologie ist Hera die Göttin der Ernte.", false),
            ("Liechtenstein hat keinen eigenen Flughafen.", true),
            ("Die meisten Subarus werden in China hergestellt.", false)};

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion

    }
}
