using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Actividad_1_en_ASP 
{
    public partial class Ejercicios : System.Web.UI.Page
    {
        // Propiedad para el contador de la página (uso ViewState por defecto)
        private int ContadorPagina
        {
            get
            {
                // Obtiene el valor de ViewState. Si es nulo, devuelve 0
                return ViewState["ContadorRecargasPagina"] != null ? (int)ViewState["ContadorRecargasPagina"] : 0;
            }
            set
            {
                // Valor en ViewState
                ViewState["ContadorRecargasPagina"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Mensaje de carga (Ejercicio 9)
            if (!IsPostBack)
            {
                // Primera carga de la página (Sin PostBack)
                lblMensajeCarga.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";
                lblMensajeCarga.CssClass = "mensaje"; 
            }
            else
            {
                // Recarga de la página (Con PostBack)
                lblMensajeCarga.Text = "Esta página ya ha sido visitada";
                lblMensajeCarga.CssClass = "mensaje recarga";
            }

            // Contadores (Ejercicio 10)

            // Contador de usuarios en la aplicación (Application State)
            // Lock sirve para tener seguridad al acceder a Application

            lock (Application)
            {
                // Asegura que el contador de Application no sea nulo
                if (Application["ContadorUsuariosApp"] == null)
                {
                    Application["ContadorUsuariosApp"] = 0;
                }
                lblContadorApp.Text = "Usuarios en la aplicación: " + Application["ContadorUsuariosApp"].ToString();
            }


            // Contador de recargas de la página
            ContadorPagina++; // Incrementa el contador usando la propiedad
            lblContadorPagina.Text = "Esta página ha sido recargada: " + ContadorPagina.ToString() + " veces";
        }
    }
}