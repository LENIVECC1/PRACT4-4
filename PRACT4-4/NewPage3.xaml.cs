namespace PRACT4_4;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void Creator_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("����������", "������ ��������� ���� ������� ��������� �������� �� ������ ���-44", "�����");
    }

    private void Program_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("����������", "��������� ���������� ��������� ������� �� �������, ��������� �� ���������� ������ ���� ����� �������� ������ ���������� ������.", "�����");

    }

    private void Number_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("����������", "������ ��������� ����������� ��� ����� ������������ ������ �4 �������� 1.", "�����");

    }
}