namespace Sample.Traditional
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoControl : ContentView
	{
        public static readonly BindableProperty TitleProperty 
            = BindableProperty.Create(
                "Title",
                typeof(String),
                typeof(DemoControl));

        public String Title
        {
            get => (String)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty DescriptionProperty
            = BindableProperty.Create(
                "Description",
                typeof(String),
                typeof(DemoControl));

        public String Description
        {
            get => (String)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly BindableProperty BackgroundColorButtonProperty
            = BindableProperty.Create(
                "BackgroundColorButton",
                typeof(Color),
                typeof(DemoControl));

        public Color BackgroundColorButton
        {
            get => (Color)GetValue(BackgroundColorButtonProperty);
            set => SetValue(BackgroundColorButtonProperty, value);
        }

        public DemoControl()
		{
		    InitializeComponent();

            BindingContext = this;
		}
	}
}