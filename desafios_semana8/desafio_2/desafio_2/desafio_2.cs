// Interfaz INotificable
interface INotificable
{
    void Notifica(string mensaje);
}

// Implementación NotificacionEmail
class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por correo electrónico a {DireccionCorreo}:\n{mensaje}");
    }
}

// Implementación NotificacionWhatsapp
class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por WhatsApp al número {NumeroTelefono}:\n{mensaje}");
    }
}

// Implementación NotificacionSMS
class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por SMS al número {NumeroTelefono}:\n{mensaje}");
    }
}

// Método Main
class Program
{
    static void Main(string[] args)
    {
        // Instancia de NotificacionEmail
        NotificacionEmail notificacionEmail = new NotificacionEmail();
        notificacionEmail.DireccionCorreo = "usuario@ejemplo.com";
        notificacionEmail.Notifica("Este es un mensaje de prueba enviado por correo electrónico.");

        // Instancia de NotificacionWhatsapp
        NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp();
        notificacionWhatsapp.NumeroTelefono = "+1234567890";
        notificacionWhatsapp.Notifica("Este es un mensaje de prueba enviado por WhatsApp.");

        // Instancia de NotificacionSMS
        NotificacionSMS notificacionSMS = new NotificacionSMS();
        notificacionSMS.NumeroTelefono = "+9876543210";
        notificacionSMS.Notifica("Este es un mensaje de prueba enviado por SMS.");

        Console.ReadLine();
    }
}