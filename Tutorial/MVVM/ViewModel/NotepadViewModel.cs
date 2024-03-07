using Tutorial.Core;


namespace Tutorial.MVVM.ViewModel
{
    internal class NotepadViewModel : ObservableObjects
    {


        private string _text;

        public string Texts
        {
            get { return _text; }
            set { SetProperty(ref _text, value); SaveText(); }

        }

        
        // Method to load text from a file
        public NotepadViewModel()
        {
            // Load text from application settings when the view model is initialized
            LoadText();
        }

        // Method to load text from application settings
        private void LoadText()
        {
            // Retrieve the text from application settings
            Texts = Properties.Settings.Default.NotepadText;
        }

        // Method to save text to application settings
        private void SaveText()
        {
            // Save the text to application settings
            Properties.Settings.Default.NotepadText = Texts;
            Properties.Settings.Default.Save();
        }
    }
}
