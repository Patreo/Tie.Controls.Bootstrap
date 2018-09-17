using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Samples.css
{
    public partial class Tables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // The Page is accessed for the first time. 
            if (!this.IsPostBack)
            {
                // Initialize the sorting expression
                this.ViewState["SortExpression"] = "# ASC";

                // Populate the GridViews 
                this.BindGridView(this.gvBasic, true);
            }
            this.BindGridView(this.gvStriped);
            this.BindGridView(this.gvBordered);
            this.BindGridView(this.gvHover);
            this.BindGridView(this.gvCondensed);
            this.BindGridView(this.gvResponsive);
        }

        // Initialize the DataTable
        private DataTable GetDataSource(bool loadFull)
        {
            string viewStateKey = "DataTable" + (loadFull ? "Full" : "Short");
            DataTable dataTable = this.ViewState[viewStateKey] as DataTable;
            if(dataTable == null)
            {
                // Create a DataTable object
                dataTable = new DataTable();

                // Add four columns to the DataTable.
                dataTable.Columns.Add("#");
                dataTable.Columns.Add("First Name");
                dataTable.Columns.Add("Last Name");
                dataTable.Columns.Add("Username");

                // and set the starting value and increment. 
                dataTable.Columns["#"].AutoIncrement = true;
                dataTable.Columns["#"].AutoIncrementSeed = 1;
                dataTable.Columns["#"].AutoIncrementStep = 1;

                // Set # column as the primary key.
                DataColumn[] dcKeys = new DataColumn[1];
                dcKeys[0] = dataTable.Columns["#"];
                dataTable.PrimaryKey = dcKeys;

                // Add new rows into the DataTable
                dataTable.Rows.Add(    null, "Mark",        "Otto",         "@mdo");
                dataTable.Rows.Add(    null, "Jacob",       "Thornton",     "@fat");
                dataTable.Rows.Add(    null, "Larry",       "the Bird",     "@twitter");
                dataTable.Rows.Add(    null, "Pedro",       "Fernandes",    "@pmcfernandes");
                dataTable.Rows.Add(    null, "Kinsey",      "Roberts",      "@kinzdesign");
                if (loadFull)
                {
                    dataTable.Rows.Add(null, "Andres",      "Galante",      "@andresgalante");
                    dataTable.Rows.Add(null, "Bardi",       "Harborow",     "@bardiharborow");
                    dataTable.Rows.Add(null, "Connor",      "Sears",        "@connors");
                    dataTable.Rows.Add(null, "Chris",       "Rebert",       "@cvrebert");
                    dataTable.Rows.Add(null, "Gleb",        "Mazovetskiy",  "@glebm");
                    dataTable.Rows.Add(null, "Heinrich",    "Fenkart",      "@hnrch02");
                    dataTable.Rows.Add(null, "Justin",      "Dorfman",      "@jdorfman");
                    dataTable.Rows.Add(null, "Johann",      "S",            "@Johann-S");
                    dataTable.Rows.Add(null, "Julian",      "Thilo",        "@juthilo");
                    dataTable.Rows.Add(null, "Patrick",     "Lauke",        "@patrickhlauke");
                    dataTable.Rows.Add(null, "Thomas",      "McDonald",     "@thomas-mcdonald");
                    dataTable.Rows.Add(null, "XhmikosR",    "",             "@XhmikosR");
                    dataTable.Rows.Add(null, "Zac",         "Echola",       "@zacechola");
                }

                // Store the DataTable in this.ViewState
                this.ViewState[viewStateKey] = dataTable;
            }
            return dataTable;
        }

        private void BindGridView(GridView gridView, bool loadFull = false)
        {


            // Get the DataTable from this.ViewState. 
            DataTable dataTable = GetDataSource(loadFull);

            // Convert the DataTable to DataView. 
            DataView dataView = new DataView(dataTable);

            // Set the sort column and sort order. 
            if (loadFull)
            {
                dataView.Sort = this.ViewState["SortExpression"].ToString();
            }

            // Enable the GridView paging option and specify the page size. 
            gridView.AllowPaging = loadFull;
            gridView.PageSize = 5;

            // Enable the GridView sorting option. 
            gridView.AllowSorting = loadFull;

            // Bind the GridView control. 
            gridView.DataSource = dataView;
            gridView.DataBind();
        }

        // GridView.PageIndexChanging Event 
        protected void gvBasic_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the index of the new display page.   
            this.gvBasic.PageIndex = e.NewPageIndex;

            // Rebind the GridView control to  
            // show data in the new page. 
            this.BindGridView(this.gvBasic, true);
        }

        // GridView.Sorting Event 
        protected void gvBasic_Sorting(object sender, GridViewSortEventArgs e)
        {
            string expression = this.ViewState["SortExpression"].ToString();
            int lastSpace = expression.LastIndexOf(' ');
            string field = expression.Substring(0, lastSpace);
            string order = expression.Substring(lastSpace + 1);

            // If the sorting column is the same as the previous one,  
            // then change the sort order. 
            if (field == e.SortExpression)
            {
                if (order == "ASC")
                {
                    this.ViewState["SortExpression"] = e.SortExpression + " " + "DESC";
                }
                else
                {
                    this.ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
                }
            }
            // If sorting column is another column,  
            // then specify the sort order to "Ascending". 
            else
            {
                this.ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
            }

            // Rebind the GridView control to show sorted data. 
            BindGridView(gvBasic, true);
        }
    }
}