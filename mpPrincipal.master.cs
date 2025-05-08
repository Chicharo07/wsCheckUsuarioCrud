using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsCheckUsuario
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validación de la Sesión Activa
            if (Session["nomUsuario"].ToString() == "" &&
               Session["usuUsuario"].ToString() == "" &&
               Session["urlUsuario"].ToString() == "" &&
               Session["rolUsuario"].ToString() == "")
            {

                //Mensaje de acceco denegado y enviar a wsAcceso.aspx
                Response.Write("<script language='javascript'>" +
                                "alert('Acceso Denegado');" +
                            "</script>");
                Response.Write("<script language='javascript'>" +
                    "document.location.href='wpAcceso.aspx';" +
                    "</script>");
            }

            //Actualización de etiquetas de la aplicación
            Label1.Text = Application["nomEmpresa"].ToString();
            Label6.Text = Session["nomUsuario"].ToString() + " (" +
                          Session["usuUsuario"].ToString() + ") - " +
                          Session["rolUsuario"].ToString();

            //Configuracion de la foto del usuario en sesion
            Image2.ImageUrl = Session["urlUsuario"].ToString();

        }


        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            //Cerrar la sesión dell usuario
            Session["nomUsuario"] = "";
            Session["usuUsuario"] = "";
            Session["rolUsuario"] = "";
            Session["urlUsuario"] = "";

            Response.Write("<script language='javascript'>" +
                                          "alert('Sesión cerrada exitosamente!');" +
                                      "</script>");
            Response.Write("<script language='javascript'>" +
                "document.location.href='wpAcceso.aspx';" +
                "</script>");


        }
    }
}