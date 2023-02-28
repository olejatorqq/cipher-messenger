using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void ClickbuttonLogIn(object sender, EventArgs e)
    {
        if (entryLogin.Text.Length != 0 && entryPassword.Text.Length != 0)
        {
            //entryPassword.Visibility = true;
            ShowMessageBox($"Логин: {entryLogin.Text}\nПароль: {entryPassword.Text}");
        }
        else
        {
            ShowMessageBox("Введите логин и пароль!");
        }

        //Console.WriteLine($"{entryLogin.Text}");
    }

    public void ShowMessageBox(string text)
    {
        MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
            MessageType.Info,
            ButtonsType.Ok, text);
            md.Run();
            md.Destroy();
    }

    protected void ClickedCheckVisiblePassword(object sender, EventArgs e)
    {
        if (checkbuttonVisiblePassword.Active)
        {
            entryPassword.Visibility = true;
        }
        else
        {
            entryPassword.Visibility = false;
        }

    }
}
