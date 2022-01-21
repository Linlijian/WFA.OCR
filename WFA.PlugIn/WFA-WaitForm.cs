using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.PlugIn
{
    public partial class WaitForm : Form
    {
        public Action Worker { get; set; }
        public WaitForm(Action _worker)
        {
            InitializeComponent();
            if (_worker == null)
                throw new ArgumentNullException();
            Worker = _worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
