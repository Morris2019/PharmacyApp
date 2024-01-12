using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class ConfrimMedicalRequest 
    {
        public ConfrimMedicalRequest(int DoctorId, string DocImageUrl, long DocTel, string DocTitle, string FirstName, string LastName)
        {
            InitializeComponent();
        }

        async void ClosePostBill(object sender, EventArgs e)
        {
        }
    }
}
