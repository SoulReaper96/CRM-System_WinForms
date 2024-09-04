using System.Xml.Linq;

namespace CRM_System_WinForms
{
    public partial class CRM_System_Main : Form
    {
        private List<Customer> customers = new List<Customer>();

        public CRM_System_Main()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string name = Name_txtBox.Text;
            string email = Email_txtBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter both name and email.");
                return;
            }

            Customer customer = new Customer { Name = name, Email = email };
            customers.Add(customer);

            Customers_lstBox.Items.Add(customer);
            Name_txtBox.Clear();
            Email_txtBox.Clear();
        }
    }

    public class Customer
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Email})";
        }
    }
}
