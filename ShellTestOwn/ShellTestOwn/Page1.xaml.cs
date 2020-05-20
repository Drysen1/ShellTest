using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeTest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellTestOwn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private int _clicks = 0;

        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (_clicks)
                {
                    case 0:
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                    case 1:
                        mergedDictionaries.Add(new GreenTheme());
                        break;
                    case 2:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }

                _clicks++;

                if (_clicks > 2)
                {
                    _clicks = 0;
                }
            }
        }
    }
}