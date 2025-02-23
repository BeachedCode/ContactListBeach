namespace ContactListBeach;

public partial class ContactDetails : ContentPage
{
	public ContactDetails(Contact item)
	{
		InitializeComponent();

		ContactImage.Source = item.ImageName;
		LblContactName.Text = item.Name;
		LblContactDesc.Text = item.Description;
        LblContactEmail.Text = item.Email;
		LblContactPhoneNum.Text = item.PhoneNum;

    }

	private void ReturnClicked(object sender, EventArgs e)
	{
		Navigation.PopToRootAsync();
	}
}