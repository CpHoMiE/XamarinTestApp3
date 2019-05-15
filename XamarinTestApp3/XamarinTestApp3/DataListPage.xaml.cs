using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataListPage : ContentPage
	{
        EmpViewModel model = new EmpViewModel();

		public DataListPage ()
		{
			InitializeComponent ();
            listEmp.ItemsSource = model.EmpList;
		}

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (txtEmpname.Text == null || txtEmpname.Text == "" || txtEmpno.Text == null || txtEmpno.Text == "")
            {

            }
            else
            {
                model.EmpList.Add(new Emp()
                {
                    EmpNo = txtEmpno.Text,
                    EmpName = txtEmpname.Text,
                    IsChecked = false
                });

                txtEmpno.Text = "";
                txtEmpname.Text = "";                
            }
        }
    }
}