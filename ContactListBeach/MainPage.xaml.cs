using System.Linq;
using System.Runtime.CompilerServices;

namespace ContactListBeach
{
    public partial class MainPage : ContentPage
    {
        public List<ContactGroup> Groups = new List<ContactGroup>();

        public MainPage()
        {
            InitializeComponent();

            Groups.Add(new ContactGroup("A", new List<Contact> {
                new Contact(){Name="Arin",ImageName="joel.png",Email="Arin.Baskens11@gmail.com",PhoneNum="(513)515-5140",Description="Father"},
                new Contact(){Name="Abby",ImageName="abby.png",Email="Abby.Baskens45@gmail.com",PhoneNum="(513)777-7560",Description="Mother"},
                new Contact(){Name="Amelia",ImageName="susan.png",Email="Amelia.Robins77@gmail.com",PhoneNum="(513)777-7560",Description="College Friend"},
            }));

            Groups.Add(new ContactGroup("B", new List<Contact> {
                new Contact(){Name="Bobby",ImageName="joel.png",Email="Bobby.Burns15@gmail.com",PhoneNum="(513)500-5040",Description="Childhood Friend"},
                new Contact(){Name="Bailey",ImageName="abby.png",Email="Bailey.Cromwell47@gmail.com",PhoneNum="(513)747-7060",Description="College Friend"},
                new Contact(){Name="Blake",ImageName="john.png",Email="Blake.West37@gmail.com",PhoneNum="(513)674-6560",Description="College Friend"},
            }));

            Groups.Add(new ContactGroup("C", new List<Contact> {
                new Contact(){Name="Chris",ImageName="john.png",Email="Chris.West19@gmail.com",PhoneNum="(513)404-4140",Description="Boss"},
                new Contact(){Name="Connor",ImageName="joel.png",Email="Connor.Baskens40@gmail.com",PhoneNum="(513)707-7570",Description="Brother"},
                new Contact(){Name="Cassie",ImageName="abby.png",Email="Cassie.Elsher54@gmail.com",PhoneNum="(513)557-5570",Description="Coworker"},
            }));

            Groups.Add(new ContactGroup("D", new List<Contact> {
                new Contact(){Name="David",ImageName="joel.png",Email="David.Cassidy41@gmail.com",PhoneNum="(513)554-5650",Description="Coworker"},
                new Contact(){Name="Dana",ImageName="abby.png",Email="Dana.Baskens89@gmail.com",PhoneNum="(513)341-3530",Description="Sister"},
                new Contact(){Name="Diana",ImageName="susan.png",Email="Diana.Marley32@gmail.com",PhoneNum="(513)418-4143",Description="College Friend"},
            }));

            Groups.Add(new ContactGroup("E", new List<Contact> {
                new Contact(){Name="Ethan",ImageName="joel.png",Email="Ethan.Hayes20@gmail.com",PhoneNum="(513)400-5440",Description="College Friend"},
                new Contact(){Name="Eva",ImageName="susan.png",Email="Eva.Baskens78@gmail.com",PhoneNum="(513)888-8860",Description="Sister"},
                new Contact(){Name="Ella",ImageName="abby.png",Email="Ella.Adler37@gmail.com",PhoneNum="(513)757-6760",Description="Coworker"},
            }));

            LvContacts.ItemsSource = Groups;
        }

        private void Contact_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedContact = e.CurrentSelection.FirstOrDefault() as Contact;
            if (selectedContact == null) return;
            Navigation.PushAsync(new ContactDetails(selectedContact));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
