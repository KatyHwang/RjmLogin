using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RjmLogin
{
  
    class Stock
    {
        public    string  name;
        public   int  no;
        public   string  vendor;
        public    int cost; 
        DataTable dt = new DataTable();

        public DataTable AddColumns(DataTable d)
        {
            d.Columns.Add("No");
            d.Columns.Add("Name");
            d.Columns.Add("Vendor");
            d.Columns.Add("Cost");
            d.Columns.Add("CreatTime");
            return d;
        }


        public DataTable CreatData(DataTable d)
        {
         
            DataRow row = d.NewRow();
            row["No"]  =   no; 
            row["Name"] = name;
            row["Vendor"] = vendor;
            row["Cost"] = cost;
            row["CreatTime"] = DateTime.Now.ToString();

            d.Rows.Add(row);
            return d;
        }

      
        public int   CreatNo(DataTable d)
        {
            no = d.Rows.Count +1;
            return no;
        }

     
}

}
