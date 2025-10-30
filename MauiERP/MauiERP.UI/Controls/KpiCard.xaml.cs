using Microsoft.Maui.Controls;

namespace MauiERP.UI.Controls;

public partial class KpiCard : ContentView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(KpiCard), string.Empty);

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(string), typeof(KpiCard), string.Empty);

    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(KpiCard), string.Empty);

    public KpiCard()
    {
        InitializeComponent();
        TitleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Title), source: this));
        ValueLabel.SetBinding(Label.TextProperty, new Binding(nameof(Value), source: this));
        SubtitleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Subtitle), source: this));
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public string Subtitle
    {
        get => (string)GetValue(SubtitleProperty);
        set => SetValue(SubtitleProperty, value);
    }
}