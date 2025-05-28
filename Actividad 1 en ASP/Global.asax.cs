using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Actividad_1_en_ASP 
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Este evento se utilzia una sola vez cuando la aplicación se inicia por primera vez
            // inicia recursos globales y contadores de Application

            Application["ContadorUsuariosApp"] = 0; // Inicia el contador de usuarios globales
            System.Diagnostics.Debug.WriteLine("Application_Start: ContadorUsuariosApp inicializado en 0.");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Este evento se dispara cada vez que una nueva sesión de usuario comienza 

            lock (Application) // Bloquea el objeto Application para tener seguridad
            {
                // Incrementa el contador de usuarios de la aplicación.
                int currentUsers = (int)Application["ContadorUsuariosApp"];
                Application["ContadorUsuariosApp"] = currentUsers + 1;
                System.Diagnostics.Debug.WriteLine($"Session_Start: Usuario nuevo. ContadorUsuariosApp: {Application["ContadorUsuariosApp"]}");
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Este evento aparece cando la sesión de un usuario termina (por inactividad)
            // Elimina contadores de usuarios activos si es necesario 

            System.Diagnostics.Debug.WriteLine($"Session_End: Sesión terminada.");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            // Este evento aparece una sola vez cuando la aplicación se detiene. 
            System.Diagnostics.Debug.WriteLine("Application_End: La aplicación se ha detenido.");
        }

        // Otros eventos comunes (mantener comentados si no se usan)
        
        protected void Application_Error(object sender, EventArgs e)
        {
            // Aparece cuando ocurre un error no manejado en la aplicación
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Aparece al principio de cada solicitud
        }
        
    }
}