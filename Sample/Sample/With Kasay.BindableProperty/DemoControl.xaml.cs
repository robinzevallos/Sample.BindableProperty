namespace Sample
{
    using Kasay.BindableProperty;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoControl : ContentView
	{
        [Bind] public String Title { get; set; }

        [Bind] public String Description { get; set; }

        [Bind] public Color BackgroundColorButton { get; set; }

        public DemoControl()
		{
			InitializeComponent();
        }
	}
}