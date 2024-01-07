namespace dvargasSemana2.vistas;

public partial class vistaLogin : ContentPage
{
	public vistaLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        // Definir las listas de usuarios y contraseñas
        List<string> usuarios = new List<string> { "daniel", "alejandro" };
        List<string> contrasenias = new List<string> { "123", "321" };

        // Obtener los valores ingresados por el usuario
        string usuarioIngresado = txtUsuario.Text.ToLower(); // Convertir a minúsculas para hacer la comparación sin importar mayúsculas/minúsculas
        string contraseniaIngresada = txtContraseña.Text;

        // Verificar si el usuario y la contraseña coinciden
        bool credencialesValidas = false;

        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarioIngresado == usuarios[i] && contraseniaIngresada == contrasenias[i])
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
            Navigation.PushAsync(new vSecundaria());
        }
        else
        {
            DisplayAlert("Alerta", "Datos incorrectos", "Cancelar");
        }
    }
}