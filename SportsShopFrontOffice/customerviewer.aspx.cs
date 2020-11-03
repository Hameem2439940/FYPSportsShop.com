using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customerviewer : System.Web.UI.Page
{
    private object txtCustomerID;
    private object txtUsername;
    private object txtEmailAddress;
    private object txtPostcode;

    public string CustomerID { get; private set; }
    public object Username { get; private set; }
    public object EmailAddress { get; private set; }
    public object Postcode { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        customerviewer customer = new customerviewer();
        customer = (customerviewer)Session["customer"];
        Response.Write(customer.CustomerID);
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        customerviewer customer = new customerviewer();
        customer.CustomerID = CustomerID;
        customer.Username = txtUsername;
        customer.EmailAddress = txtEmailAddress;
        customer.Postcode = txtPostcode;
        Session["customer"] = customer;
        Response.Write("customerviewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        customerviewer customer = new customerviewer();
        customer.CustomerID = CustomerID;
        customer.Username = txtUsername;
        customer.EmailAddress = txtEmailAddress;
        customer.Postcode = txtPostcode;
        Session["customer"] = customer;
        Response.Write("customerviewer.aspx");
    }
}