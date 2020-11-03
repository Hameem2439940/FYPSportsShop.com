using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportsShopClasses;

public partial class customer : System.Web.UI.Page
{
    private object txtCustomerID;

    public string CustomerID { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        customer customer = new customer();
        customer = (customer)Session["Customer"];
        Response.Write(customer.txtCustomerID);
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        customer customer = new customer();
        customer.CustomerID = CustomerID;
        Session["customer"] = customer;
        Response.Redirect("customer.aspx");
    }


}