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

    private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtDato2.Text);
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 10", "Cancelar");
                txtDato1.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }

    private void txtDato3_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtDato3.Text);
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 10", "Cancelar");
                txtDato1.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }

    private void txtDato4_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtDato4.Text);
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 10", "Cancelar");
                txtDato1.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }
    private double sumarnotas(double nota1, double nota2)
    {
        double notaParcial1 = nota1 * 0.3;
        double notaExamen1 = nota2 * 0.2;
        double sumanota = (notaParcial1 + notaExamen1);
        return sumanota;
    }
    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToDouble(txtDato1.Text);
        double nota2 = Convert.ToDouble(txtDato3.Text);
        double suma = sumarnotas (nota1, nota2);
        double nota3 = Convert.ToDouble(txtDato2.Text);
        double nota4 = Convert.ToDouble(txtDato4.Text);
        double suma2 = sumarnotas (nota3, nota4);
        lblCalifi1.Text = "Nota primer parcial: "+suma.ToString();
        lblCalifi2.Text = "Nota segundo parcial: " + suma2.ToString();
        double final = suma + suma2;
        if (final > 7)
        {

            lblEstadoFinal.Text = "APROBADO "+final;
            lblEstadoFinal.TextColor = Color.FromRgb(0,128,0);
        }
        else if(final >= 5 && final <6.99)
        {
            lblEstadoFinal.Text = "Supletorio " + final;
            lblEstadoFinal.TextColor = Color.FromRgb(255, 165, 0);
        }
        else if(final<5)
        {
            lblEstadoFinal.Text = "REPROBADO "+final;
            lblEstadoFinal.TextColor = Color.FromRgb(255, 0, 0);
        }
    }
}