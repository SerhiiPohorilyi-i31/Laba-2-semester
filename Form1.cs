using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_task21._2
{
    public partial class Провідник: Form
    {
        public Провідник()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Завантаження логічних дисків у TreeView
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode rootNode = new TreeNode(drive.Name)
                {
                    Tag = drive.RootDirectory.FullName
                };
                treeViewFolders.Nodes.Add(rootNode);
            }
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Відображення файлів у ListView
            string selectedPath = e.Node.Tag.ToString();
            listViewFiles.Items.Clear();

            // Завантаження файлів
            foreach (var file in Directory.GetFiles(selectedPath))
            {
                listViewFiles.Items.Add(Path.GetFileName(file));
            }
        }

    }
}
