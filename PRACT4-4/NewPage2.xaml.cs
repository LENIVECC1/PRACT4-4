namespace PRACT4_4;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
    }

    private void off_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var z = sender as CheckBox;
        switch (z.IsChecked)
        {
            case true:
                st1.IsEnabled = true;
                break;

            case false:
                st1.IsEnabled = false;
                break;
        }
    }

    string s="TEXT";
    public void rb2_1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var z = sender as RadioButton;
        switch (z.Content)
        {
            case "����":  s = "������, �������, �������"; break;
            case "�����":  s = "����, ������, ���"; break;
            case "����":  s = "����, ����, ������"; break;
            case "�����":  s = "��������, �������, ������"; break;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        var p = sender as Button;
        switch(p.Text)
        {
            case "�������" :text2.Text = s ;break;
        }


    }
}