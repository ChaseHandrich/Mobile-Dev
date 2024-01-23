namespace Roman;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

    void Convert_Clicked(System.Object sender, System.EventArgs e)
    {
        Int32 intInput;
        bool isNumber;
        Converter converter = new Converter();
        isNumber = Int32.TryParse(txtInput.Text, out intInput);

        if (isNumber)
        {
            lblDisplay.Text = converter.NumberToRoman(intInput);
        }
        else
        {
            lblDisplay.Text = converter.RomanToNumber(txtInput.Text.ToUpper()).ToString();
        }
    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        lblDisplay.Text = "0";
        txtInput.Text = string.Empty;
    }
}


