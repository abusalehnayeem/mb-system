using Microsoft.Maui.Controls;

namespace MauiERP.UI.Components
{
    public partial class StatusDot : ContentView
    {
        public static readonly BindableProperty StatusColorProperty =
            BindableProperty.Create(nameof(StatusColor), typeof(Color), typeof(StatusDot), Colors.Green);

        public Color StatusColor
        {
            get => (Color)GetValue(StatusColorProperty);
            set => SetValue(StatusColorProperty, value);
        }

        public StatusDot()
        {
            InitializeComponent();
            Dot.Color = StatusColor;
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == StatusColorProperty.PropertyName)
            {
                Dot.Color = StatusColor;
            }
        }
    }
}
