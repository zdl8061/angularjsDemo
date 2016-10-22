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
        var _tagUrl = Request.Url.AbsolutePath;

        var _urlQuery = HttpUtility.ParseQueryString(Request.Url.Query);
        _urlQuery["tags"] += string.IsNullOrEmpty(_urlQuery["tags"]) ? "3" : ",3";

        _tagUrl += "?" + Uri.UnescapeDataString(_urlQuery.ToString());

        Response.Write(_tagUrl);
    }

}

