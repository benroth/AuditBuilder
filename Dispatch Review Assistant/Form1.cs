using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace AuditBuilder
{
    public partial class Form1 : Form
    {
        AuditForm audit = new AuditForm();
        public string sqlLocation = "Data Source="+ new FileInfo(Path.GetDirectoryName(Application.ExecutablePath) + "\\DRAssistant.sdf").ToString(); 
        List<AuditSelection> auditSelections = new List<AuditSelection>();

        public Form1()
        {
            InitializeComponent();
            LoadAudits();
        }

        private void btnBuildAudit_Click(object sender, EventArgs e)
        {
            BuildAudit();
        }

        private void Radio_Checked(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            try
            {
                auditSelections = audit.GrabAudit(sqlLocation, radio.Text);
                PopulateCheckBoxes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadAudits()
        {
            List<string> radios = new List<string>();
            try 
            {
                pnlAuditTypes.Margin = new Padding(0);
                radios = audit.GrabAuditTypes(sqlLocation);
                foreach (string entry in radios)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = entry;
                    radio.Margin = new Padding(5,0,5,0);
                    radio.AutoSize = true;
                    radio.Click += new System.EventHandler(this.Radio_Checked);
                    pnlAuditTypes.Controls.Add(radio);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }                
        }

        public void BuildAudit()
        {
            StringBuilder audit = new StringBuilder();

            for (int i = 0; i < auditSelections.Count(); i++)
            {
                CheckBox check = (CheckBox)pnlCheckBoxes.Controls[i];
                if (check.CheckState.ToString() == auditSelections[i].checkValidState)
                    audit.AppendLine(auditSelections[i].checkAuditText);
            }
            auditBox.Text = audit.ToString();
        }

        public void PopulateCheckBoxes()
        {
            pnlCheckBoxes.Controls.Clear();
            ToolTip toolTip1 = new ToolTip { AutoPopDelay = 5000, InitialDelay = 1000, ReshowDelay = 500, ShowAlways = true };

            foreach (AuditSelection choice in auditSelections)
            {
                CheckBox check = new CheckBox();
                check.Name = choice.checkID.ToString();
                check.Text = choice.checkLabel.Trim();
                check.ThreeState = Enabled;
                check.Margin = new Padding(0);
                check.AutoSize = true;
                toolTip1.SetToolTip(check, choice.checkToolTip.Trim());
                pnlCheckBoxes.Controls.Add(check);
            }
        }                
    }
}
