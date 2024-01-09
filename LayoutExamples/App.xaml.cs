namespace LayoutExamples;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AbsoluteLayoutExamplePage();
        //MainPage = new AbsoluteLayoutEntryEx();
    }
}
