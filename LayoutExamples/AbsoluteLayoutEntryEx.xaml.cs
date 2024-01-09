namespace LayoutExamples;
using System.Text.RegularExpressions;

public partial class AbsoluteLayoutEntryEx : ContentPage
{
	public AbsoluteLayoutEntryEx()
	{
		InitializeComponent();
	}

    private void theEntry_Focused(object sender, FocusEventArgs e)
    {

    }

    private void theEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        theTitle.IsVisible = theEntry.Text.Length > 0;
        theError.IsVisible = !CheckEmail(theEntry.Text);
    }

    bool CheckEmail(string email)
    {

        bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        return isEmail || email == "";
    }
}