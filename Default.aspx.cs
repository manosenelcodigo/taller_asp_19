using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["contador"]==null)//si NO existe la cookie llamada contador
        {
            HttpCookie cookie = new HttpCookie("contador","texto de la cookie ñandú");
            cookie.Expires=new DateTime(2017,08,01);
            Response.Cookies.Add(cookie);//añadimos la cookie a la respuesta HTTP
            titulo.InnerHtml = "Hola bienvenido";
        }
        else
        {
            titulo.InnerHtml = "Gracias por volver a visitarnos";
        }
    }
}