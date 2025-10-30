using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiERP.UI.Components
{
    public partial class Fab : ContentView
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(Fab));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public Fab()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}
