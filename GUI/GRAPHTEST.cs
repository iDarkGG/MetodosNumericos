using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WinFormsApp1;

public partial class test : Form
{
    private WebView2 webView;
    Herramientas hr = new Herramientas();
    

    public test()
    {
        InitializeComponent();
        InitializeWebView();

    }

    private async void InitializeWebView()
    {
        webView = new WebView2
        {
            Dock = DockStyle.Fill
        };
        
       
        this.Controls.Add(webView);

        
        await webView.EnsureCoreWebView2Async();
        
        webView.Source = new Uri("http://localhost:8000/test - Copy.html");
        webView.NavigationCompleted += WebView_NavigationCompleted;

    }
    
    private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
    {
        if (e.IsSuccess)
        {
            await Task.Delay(1500);
            List<string> data = new List<string>();
            
            data.AddRange(hr.DataPayload());
            await SendCommandToGeoGebra(data[0]);
            await SendCommandToGeoGebra("A="+"("+data[1]+','+'0'+")");
            await SendCommandToGeoGebra("B="+"("+data[2]+','+'0'+")");
        }
        else
        {
            MessageBox.Show("Error loading the page.");
        }
    }
    
    
    private async Task SendCommandToGeoGebra(string command)
    {
        string escapedCommand = command.Replace("\"", "\\\"");
        
        if (webView.CoreWebView2 != null)
        {
            await webView.CoreWebView2.ExecuteScriptAsync($"sendGeoGebraCommand(\"{escapedCommand}\")");
        }
        else
        {
            MessageBox.Show("WebView2 is not ready.");
        }
    }

    private void test_Resize(object sender, EventArgs e)
    {
        Console.WriteLine("current size:"+"Width:"+this.Width+"Height:"+this.Height);
    }
}