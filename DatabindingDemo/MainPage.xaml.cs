using System.ComponentModel;
using DatabindingDemo.Models;

namespace DatabindingDemo;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	Person person = new Person();
	public MainPage()
	{
		InitializeComponent();

		person = new Person
		{
			Name = "John",
			Phone = "9999",
			Address = "123 Main St"
		};

		BindingContext = person;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		//person.Name = "Jane";
		//person.Phone = "8888";
		//person.Address = "456 Elm St";

		person = new Person
		{
			Name = "Jane",
			Phone = "8888",
			Address = "456 Elm St"
		};

		//txtName.BindingContext = person;
		//txtName.SetBinding(Label.TextProperty, "Name");

		//Binding personBinding = new Binding();

		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//txtName.SetBinding(Label.TextProperty, personBinding);

	}





}

