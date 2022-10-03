using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in db.TBLYORUM
                            select new
                            {
                                x.YORUMID,
                                x.KULLANICIAD,
                                x.TBLBLOG.BLOGBASLIK
                            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}