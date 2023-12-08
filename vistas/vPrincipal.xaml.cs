namespace dvargasSemana2.vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "BIENVENIDO: "+usuario;
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		
		string dato = pkPaises.Items[pkPaises.SelectedIndex];
		lblSelecionado.Text = "El elemento seleccionado es "+dato;
		//DisplayAlert("Elemento Seleccionado",dato.ToString(),"Cancelar");
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha = dpFechas.Date.ToString();
		DisplayAlert("La fecha es",fecha,"Calcelar");
    }
}