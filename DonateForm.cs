using System.Windows.Forms;

namespace frm_edAI_chrAI_block
{
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
            picTCB.Image  = ResourceHelper.LoadImage("tcb.jpg");
            picMomo.Image = ResourceHelper.LoadImage("momo.jpg");
            this.Text      = Strings.Get("DonateTitle");
            lblTitle.Text  = Strings.Get("DonateLabel");
        }
    }
}
