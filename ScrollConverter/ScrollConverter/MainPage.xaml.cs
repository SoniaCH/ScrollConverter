using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollConverter
{
	public partial class MainPage : ContentPage
	{
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        bool tab1Visible = true;
        public bool Tab1Visible
        {
            get { return tab1Visible; }
            set { SetProperty(ref tab1Visible, value); }
        }


        bool tab2Visible = false;
        public bool Tab2Visible
        {
            get { return tab2Visible; }
            set { SetProperty(ref tab2Visible, value); }
        }


        bool tab3Visible = false;
        public bool Tab3Visible
        {
            get { return tab3Visible; }
            set { SetProperty(ref tab3Visible, value); }
        }

        bool tab4Visible = false;
        public bool Tab4Visible
        {
            get { return tab4Visible; }
            set { SetProperty(ref tab4Visible, value); }
        }


        public MainPage()
		{
            BindingContext = this;
			InitializeComponent();
		}

        public ICommand TabTappedCommand
        {
            get
            {
                return new Command((e) =>
                {
                    if (int.Parse(e.ToString()) == 1)
                    {
                        Tab1Visible = true;
                        Tab2Visible = false;
                        Tab3Visible = false;
                        Tab4Visible = false;
                    }
                    else if (int.Parse(e.ToString()) == 2)
                    {
                        Tab1Visible = false;
                        Tab2Visible = true;
                        Tab3Visible = false;
                        Tab4Visible = false;
                    }
                    else if (int.Parse(e.ToString()) == 3)
                    {
                        Tab1Visible = false;
                        Tab2Visible = false;
                        Tab3Visible = true;
                        Tab4Visible = false;
                    }
                    else if (int.Parse(e.ToString()) == 4)
                    {
                        Tab1Visible = false;
                        Tab2Visible = false;
                        Tab3Visible = false;
                        Tab4Visible = true;
                    }
                });
            }

        }

    }
}
