using DatabindingDemo.Models;

namespace DatabindingDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "John",
			Phone = "9999",
			Address = "123 Main St"
		};

		//Binding personBinding = new Binding();

		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//txtName.SetBinding(Label.TextProperty, personBinding);

	}





}

