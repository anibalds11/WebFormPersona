using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormPersona.CRUDOperation;

namespace WebFormPersona.View
{
    public partial class PersonaList : System.Web.UI.Page
    {
        CRUDWeb data = new CRUDWeb();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = data.GetAll();
            GridView1.DataBind();
            //Server.Transfer("~/View/Persona.aspx");
        }

        protected void GridPersona(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Eliminar")
            {
                data.Delete(int.Parse(e.CommandArgument.ToString()));
                //OnRowCommand = "GridPersona_RowCommand"
                Server.Transfer("~/View/PersonaList.aspx");
            }
        }

        protected void Create_Click(object sender, EventArgs e)
        {

            Server.Transfer("~/View/PersonaCreate.aspx");
        }
    }
}