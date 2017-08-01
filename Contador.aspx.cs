using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contador : System.Web.UI.Page
{
    private int valor;
    protected void Page_Load(object sender, EventArgs e)
    {
        String numero = "";
        if (Request.Cookies["visitas"]==null)
        {
            this.valor = 1;
            numero = valor.ToString();
            texto.InnerText = numero;
        }
        else
        {
            String valoractual = Request.Cookies["visitas"].Value;
            int valorreal = int.Parse(valoractual);
            this.valor =  valorreal+1;
            numero = valor.ToString();
            texto.InnerText = numero;
        }
        HttpCookie cookie = new HttpCookie("visitas",numero);
        cookie.Expires = new DateTime(2017,08,01);
        Response.Cookies.Add(cookie);
    }
}