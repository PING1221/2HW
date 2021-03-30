using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
			int N = 15;
			int sum = 0;
			for (int x = 1; x <= N; x++)
			{
				if ((x % 2 == 0) || (x % 3 == 0))
				{
					if ((x % 2 == 0) && (x % 3 == 0))
					{
						sum += x;
					}
					else
					{
						sum += x;
					}
				}
			}
			Response.Write(sum);
		}
    }
}