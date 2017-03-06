using System;
using Xamarin.Forms;

namespace TipCalcXamarin.ViewModels
{
	public class MainViewModel : BindableObject
	{
		private decimal _total;
		private decimal _subTotal;
		private decimal _tipPercent;
		private decimal _tipValue;
		private decimal _totalPlusTax;

		public decimal Total
		{
			get { return _total; }
			set
			{
				if (_total != value)
				{
					_total = value;
					Calculate();
				}
			}
		}

		public decimal SubTotal
		{
			get { return _subTotal; }
			set
			{
				if (_subTotal != value)
				{
					_subTotal = value;
					Calculate();
				}
			}
		}

		public decimal TipPercent
		{
			get { return _tipPercent; }
			set
			{
				if (_tipPercent != value)
				{
					_tipPercent = value;
					OnPropertyChanged("TipPercent");
					Calculate();
				}
			}
		}

		private void Calculate()
		{
			if (_subTotal != 0 && _total != 0 && _tipPercent != 0)
			{
				TipValue = _subTotal * (_tipPercent / 100);
				TotalPlusTax = _total + _tipValue;
			}
		}

		public decimal TipValue
		{
			get
			{
				return _tipValue;
			}
			set
			{
				_tipValue = value;
				OnPropertyChanged("TipValue");
			}
		}

		public decimal TotalPlusTax
		{
			get { return _totalPlusTax; }
			set
			{
				_totalPlusTax = value;
				OnPropertyChanged("TotalPlusTax");
			}
		}
	}
}
