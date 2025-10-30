using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiERP.UI.Components
{
    public partial class StickyFooter : ContentView
    {
        public static readonly BindableProperty PrimaryButtonTextProperty =
            BindableProperty.Create(nameof(PrimaryButtonText), typeof(string), typeof(StickyFooter), string.Empty);

        public static readonly BindableProperty PrimaryButtonCommandProperty =
            BindableProperty.Create(nameof(PrimaryButtonCommand), typeof(ICommand), typeof(StickyFooter));

        public static readonly BindableProperty SecondaryButtonTextProperty =
            BindableProperty.Create(nameof(SecondaryButtonText), typeof(string), typeof(StickyFooter), string.Empty);

        public static readonly BindableProperty SecondaryButtonCommandProperty =
            BindableProperty.Create(nameof(SecondaryButtonCommand), typeof(ICommand), typeof(StickyFooter));

        public static readonly BindableProperty TertiaryButtonTextProperty =
            BindableProperty.Create(nameof(TertiaryButtonText), typeof(string), typeof(StickyFooter), string.Empty);

        public static readonly BindableProperty TertiaryButtonCommandProperty =
            BindableProperty.Create(nameof(TertiaryButtonCommand), typeof(ICommand), typeof(StickyFooter));

        public string PrimaryButtonText
        {
            get => (string)GetValue(PrimaryButtonTextProperty);
            set => SetValue(PrimaryButtonTextProperty, value);
        }

        public ICommand PrimaryButtonCommand
        {
            get => (ICommand)GetValue(PrimaryButtonCommandProperty);
            set => SetValue(PrimaryButtonCommandProperty, value);
        }

        public string SecondaryButtonText
        {
            get => (string)GetValue(SecondaryButtonTextProperty);
            set => SetValue(SecondaryButtonTextProperty, value);
        }

        public ICommand SecondaryButtonCommand
        {
            get => (ICommand)GetValue(SecondaryButtonCommandProperty);
            set => SetValue(SecondaryButtonCommandProperty, value);
        }

        public string TertiaryButtonText
        {
            get => (string)GetValue(TertiaryButtonTextProperty);
            set => SetValue(TertiaryButtonTextProperty, value);
        }

        public ICommand TertiaryButtonCommand
        {
            get => (ICommand)GetValue(TertiaryButtonCommandProperty);
            set => SetValue(TertiaryButtonCommandProperty, value);
        }

        public StickyFooter()
        {
            InitializeComponent();
            BindingContext = this;
        }

    }
}
