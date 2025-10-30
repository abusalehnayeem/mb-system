using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiERP.UI.Components
{
    public partial class PrimaryActionButton : ContentView
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(PrimaryActionButton), string.Empty);

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(PrimaryActionButton));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public PrimaryActionButton()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}
