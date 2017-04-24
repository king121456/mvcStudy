using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
namespace MVCRoute
{
    public partial class Default : System.Web.UI.Page
    {

        private EmployeeRepository repository;

        public EmployeeRepository Repository
        {
            get { return repository ?? new EmployeeRepository(); }
        }
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }
    }
}