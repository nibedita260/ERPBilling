using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinifyERPBilling.UserControlles;
using MinifyERPBilling.Forms.Masters;
using MinifyERPBilling.Forms.Vouchers;
using MinifyERPBilling.UserControlles.Settings;
using MinifyERPBilling.UserControlles.Reports;

namespace MinifyERPBilling.Forms
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_party_Click(object sender, EventArgs e)
        {
            PartyUserControl party = new PartyUserControl();
            AddControlsToPanel(party);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void createItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemEntry itemEntry = new ItemEntry();
            itemEntry.ShowDialog();

        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemUserControl item = new ItemUserControl();
            AddControlsToPanel(item);
        }

        private void createBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankDetailsEntry bank = new BankDetailsEntry();
            bank.ShowDialog();
        }

        private void viewBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankUserControl bank = new BankUserControl();
            AddControlsToPanel(bank);
        }

        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentVoucher pv = new PaymentVoucher();
            pv.ShowDialog();
        }

        private void reciptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciptVoucher rv = new ReciptVoucher();
            rv.ShowDialog();
        }

        private void contraVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContraVoucher cv = new ContraVoucher();
            cv.ShowDialog();
        }

        private void jornalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalVoucher jv = new JournalVoucher();
            jv.ShowDialog();
        }

        private void purchaseVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseVoucher pv = new PurchaseVoucher();
            pv.ShowDialog();
        }

        private void sellVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellVoucher sv = new SellVoucher();
            sv.ShowDialog();
        }

        private void createPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyEntry party = new PartyEntry();
            party.ShowDialog();
        }

        private void viewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyUserControl party = new PartyUserControl();
            AddControlsToPanel(party);
        }

        private void createTradeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TradeEntry td = new TradeEntry();
            td.ShowDialog();
        }

        private void viewTradeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TradeUserControl tradeUserControl = new TradeUserControl();
            AddControlsToPanel(tradeUserControl);
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountLedgerReport accountLedgerReport = new AccountLedgerReport();
            AddControlsToPanel(accountLedgerReport);
        }

        private void viewReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement();
            AddControlsToPanel(stockManagement);
        }

       
    }
}
