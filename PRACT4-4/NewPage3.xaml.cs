namespace PRACT4_4;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void Creator_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Информация", "Данная программа была создана Поляковом Дмитрием из группы ИСП-44", "Ладно");
    }

    private void Program_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Информация", "Программа использует несколько вкладок на которых, программа от выбранного сезона года будет выводить месяца выбранного сезона.", "Ладно");

    }

    private void Number_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Информация", "Данная программа разработана для сдачи практической работы №4 Варианта 1.", "Ладно");

    }
}