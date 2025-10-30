using Microsoft.Maui.Controls;

namespace MauiERP.UI.Components
{
    public partial class ListItemTemplate : ContentView
    {
        public static readonly BindableProperty PrimaryTextProperty =
            BindableProperty.Create(nameof(PrimaryText), typeof(string), typeof(ListItemTemplate), string.Empty);

        public static readonly BindableProperty SecondaryTextProperty =
            BindableProperty.Create(nameof(SecondaryText), typeof(string), typeof(ListItemTemplate), string.Empty);

        public static readonly BindableProperty TertiaryTextProperty =
            BindableProperty.Create(nameof(TertiaryText), typeof(string), typeof(ListItemTemplate), string.Empty);

        public static readonly BindableProperty StatusColorProperty =
            BindableProperty.Create(nameof(StatusColor), typeof(Color), typeof(ListItemTemplate), Colors.Green);

        public string PrimaryText
        {
            get => (string)GetValue(PrimaryTextProperty);
            set => SetValue(PrimaryTextProperty, value);
        }

        public string SecondaryText
        {
            get => (string)GetValue(SecondaryTextProperty);
            set => SetValue(SecondaryTextProperty, value);
        }

        public string TertiaryText
        {
            get => (string)GetValue(TertiaryTextProperty);
            set => SetValue(TertiaryTextProperty, value);
        }

        public Color StatusColor
        {
            get => (Color)GetValue(StatusColorProperty);
            set => SetValue(StatusColorProperty, value);
        }

        public ListItemTemplate()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
