using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App16.Cells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TweetCell : ContentView
	{
		public TweetCell ()
		{
			InitializeComponent ();
		}
	}
}