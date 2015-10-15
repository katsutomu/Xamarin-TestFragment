using System;
using Cirrious.MvvmCross.ViewModels;

namespace Core
{
	public class DetailViewModel : MvxViewModel
	{
		private String _buttonText = "test!";
		public String ButonText
		{
			get { return _buttonText;}
			set { _buttonText = value; RaisePropertyChanged (() => ButonText); }
		}
	}
}

