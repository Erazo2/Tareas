using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            var num1 = int.Parse(txtnumero1.Text);
            var num2 = int.Parse(txtnumero2.Text);
            var re = num1 + num2;
            txtresultado.Text = re.ToString();

        }
        

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            var num1 = int.Parse(txtnumero1.Text);
            var num2 = int.Parse(txtnumero2.Text);
            var re = num1 - num2;
            txtresultado.Text = re.ToString();
        }

        private void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            var num1 = int.Parse(txtnumero1.Text);
            var num2 = int.Parse(txtnumero2.Text);
            var re = num1 * num2;
            txtresultado.Text = re.ToString();
        }

        private void btnDivicion_Clicked(object sender, EventArgs e)
        {
            var num1 = int.Parse(txtnumero1.Text);
            var num2 = int.Parse(txtnumero2.Text);
            var re = num1 / num2;
            txtresultado.Text = re.ToString();
        }
    }
}