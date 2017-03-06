using System;
using System.Collections.Generic;
using TipCalcXamarin.ViewModels;
using Xamarin.Forms;

namespace TipCalcXamarin
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();

			BindingContext = new MainViewModel();
		}
	}
}
