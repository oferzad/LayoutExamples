using Android.Content.Res;
using System.Text.RegularExpressions;

namespace LayoutExamples;

public partial class AbsoluteLayoutExamplePage : ContentPage
{
    bool move;
	double xPos, yPos;
    double xposInterval;
    double yposInterval;
    IDispatcherTimer timer;
	public AbsoluteLayoutExamplePage()
    {
		InitializeComponent();
        xPos = 0;
        yPos = 0;
        xposInterval = 0.01;
        yposInterval = 0.01;
        move = false;
        AbsoluteLayout.SetLayoutBounds(theGrayBox, new Rect(xPos, yPos, 25, 25));
        timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(20);
        timer.Tick += (s, e) => MoveBox();
        timer.Start();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        move = !move;
    }


    void MoveBox()
    {
        if (move)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                if (xPos > 1 || xPos <0)
                {
                    xposInterval = -1 * xposInterval;
                }
                if (yPos > 1 || yPos < 0)
                {
                    yposInterval = -1 * yposInterval;
                }
                xPos += xposInterval;
                yPos += yposInterval;
                AbsoluteLayout.SetLayoutBounds(theGrayBox, new Rect(xPos, yPos, 25, 25));
            });
        }
        
    }
}