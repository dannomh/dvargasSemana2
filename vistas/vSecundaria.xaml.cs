namespace dvargasSemana2.vistas;

public partial class vSecundaria : ContentPage
{
	public vSecundaria()
	{
		InitializeComponent();
	}

    private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtDato1.Text);
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 10", "Cancelar");
                txtDato1.Text = "";
            }
        }catch (Exception)
        {

        }
    }

    private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNota2.Text);
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 10", "Cancelar");
                txtNota2.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }
}