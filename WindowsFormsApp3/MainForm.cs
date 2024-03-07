using System;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MorgueTreeView.ExpandAll();
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (MorgueTreeView.SelectedNode.Name == "Node1")
            {
                var xmldata = new XmlDataDocument();
                xmldata.DataSet.ReadXml(Application.StartupPath + "\\adultMorgue.xml");

                MorgueDataGrid.DataSource = xmldata.DataSet;
                MorgueDataGrid.DataMember = "Morgue";
            }
            else if (MorgueTreeView.SelectedNode.Name == "Node2")
            {
                var xmldata = new XmlDataDocument();
                xmldata.DataSet.ReadXml(Application.StartupPath + "\\childrenMorgue.xml");

                MorgueDataGrid.DataSource = xmldata.DataSet;
                MorgueDataGrid.DataMember = "Morgue";
            }
            else if (MorgueTreeView.SelectedNode.Name == "Node3")
            {
                var xmldata = new XmlDataDocument();
                xmldata.DataSet.ReadXml(Application.StartupPath + "\\animalMorgue.xml");

                MorgueDataGrid.DataSource = xmldata.DataSet;
                MorgueDataGrid.DataMember = "Morgue";
            }
        }
    }
}
