using ClickFreeMaui.ViewModels;
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using Windows.UI.ApplicationSettings;
#endif

namespace ClickFreeMaui;

public partial class MainPage : ContentPage
{
    const int WindowWidth = 550;
    const int WindowHeight = 450;
  
    private string Status;
    MainVM mainVM;
    public MainPage()
	{
        BindingContext = new MainVM();
        InitializeComponent();
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(MainPage), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));

           // appWindow.MoveAndResize(new RectInt32(1920 / 2 - WindowWidth / 2, 1080 / 2 - WindowHeight / 2, WindowWidth, WindowHeight));
            nativeWindow.ExtendsContentIntoTitleBar = false;         

            var presenter = appWindow.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;
            presenter.IsMaximizable = false;
           
#endif
        });
    }

    private void MainBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void SettingsBtn(object sender, EventArgs e)
    {

    }

    private void AboutBtnClick(object sender, EventArgs e)
    {

    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        usbButton.BackgroundColor = Color.FromRgb(204, 27, 14);
        //Status = "please connect USB";
    }
}
