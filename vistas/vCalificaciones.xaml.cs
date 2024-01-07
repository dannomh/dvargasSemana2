namespace dvargasSemana2.vistas;

public partial class vCalificaciones : ContentPage
{
	public vCalificaciones(string usuario)
	{
		InitializeComponent();
		lblUsuarioCal.Text = usuario;
	}
}