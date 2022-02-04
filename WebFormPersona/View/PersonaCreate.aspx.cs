using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormPersona.CRUDOperation;
using WebFormPersona.Model;

namespace WebFormPersona.View
{
    public partial class PersonaCreate : System.Web.UI.Page
    {
        CRUDWeb data = new CRUDWeb();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = TextBox1.Text;
            persona.Apellido = TextBox2.Text;
            persona.Edad = int.Parse(TextBox3.Text);

            data.Insert(persona);
            Server.Transfer("~/View/PersonaList.aspx");
        }
    }
}