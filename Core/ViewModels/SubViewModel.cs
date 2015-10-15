using System;
using Cirrious.MvvmCross.ViewModels;

namespace Core
{
	public class SubViewModel : MvxViewModel
	{
		private String _buttonText = "test sub!";
		public String ButonText
		{
			get { return _buttonText;}
			set { _buttonText = value; RaisePropertyChanged (() => ButonText); }
		}
	}
}

