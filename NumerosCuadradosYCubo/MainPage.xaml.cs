namespace NumerosCuadradosYCubo;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Calcular_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(numer1.Text))
		{
			var número = Convert.ToInt32(numer1.Text);
			var num1 = Math.Pow(número, 3);
			var num2 = Math.Pow(número, 2);
			cubo.Text = Convert.ToString(num1);
			cuadrado.Text = Convert.ToString(num2);
		}
		else
		{
			DisplayAlert("Error", "Digite su número", "");
		}
	}

}


