namespace PRACT4_4;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void on_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var z = sender as CheckBox;
        switch (z.IsChecked)
        {
            case true:
                rb1_1.IsEnabled = true;
                rb1_2.IsEnabled = true;
                rb1_3.IsEnabled = true;
                rb1_4.IsEnabled = true;
                text1.IsEnabled = true; break;

            case false:
                rb1_1.IsEnabled = false;
                rb1_2.IsEnabled = false;
                rb1_3.IsEnabled = false;
                rb1_4.IsEnabled = false;
                text1.IsEnabled = false; break;
        }


    }

    private void rb1_1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var z = sender as RadioButton;
        switch (z.Content)
        {
            case "����": text1.Text = "������, �������, �������"; break;
            case "�����": text1.Text = "����, ������, ���"; break;
            case "����": text1.Text = "����, ����, ������"; break;
            case "�����": text1.Text = "��������, �������, ������"; break;
        }
    }

}