using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLYORUM.Find(y);
                TextBox1.Text = deger.TBLBLOG.BLOGBASLIK;
                TextBox2.Text = deger.KULLANICIAD;
                TextBox4.Text = deger.YORUMICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(y);
            yorum.KULLANICIAD = TextBox2.Text;
            yorum.YORUMICERIK = TextBox4.Text;       
            db.SaveChanges();
            Response.Redirect("Yorumlar.Aspx");
        }
    }
}