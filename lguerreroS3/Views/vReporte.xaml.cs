namespace lguerreroS3.Views;

public partial class vReporte : ContentPage
{
    public vReporte(string usuario)
    {
        InitializeComponent();
        DisplayAlert("Bienvenido ", usuario, "Cerrar");
    }
}