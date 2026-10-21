namespace lguerreroS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ", contrasena = " ";
    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string usuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contrasena = contrasenaNueva;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {

        try
        {
            string usuarioIngreso = txtUsuario.Text;
            string contrasenaIngreso = txtContrasena.Text;

            if (usuarioIngreso == usuario && contrasenaIngreso == contrasena)
            {
                Navigation.PushAsync(new vReporte(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Cintraseña Incorrectos", "ok");
            }
        }
        catch (Exception ex)
        {

            DisplayAlert("Error", ex.Message, "Cerrar");
        }
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}