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
        string Nome = "C# Brasil";
        string MD5 = Nome.ToMD5();

        Response.Write(MD5);

        decimal Valor = 580.78M;
        decimal Perc = 2;

        decimal IPI = Valor.CalcularIPI(Perc);

        Response.Write(IPI.ToString());
    }
}