namespace dvargasSemana2.vistas;

public partial class vistaLogin : ContentPage
{
	public vistaLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string usuario = "DANIEL";
		string contrasenia = "S";

		if(txtUsuario.Text == usuario && txtContraseña.Text==contrasenia)
		{
			Navigation.PushAsync(new vPrincipal(usuario));
		}else
		{
			DisplayAlert("Alerta", "Datos incorrectos", "Cancelar");
		}
    }
}