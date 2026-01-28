namespace WebDesign.Services
{
    public class PageHeaderService
    {
        public event Action? OnChange;
        private string _title = "Default";

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnChange?.Invoke();
            }
        }
    }
}
