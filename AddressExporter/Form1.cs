using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace AddressExporter
{
    public class PropertiesClass
    {
        public string name { get; set; }
        public object description { get; set; }
        public string TerritoryType { get; set; }
        public object TerritoryTypeCode { get; set; }
        public string TerritoryTypeColor { get; set; }
        public string TerritoryNumber { get; set; }
        public object TerritoryNotes { get; set; }
    }

    public class GeometryClass
    {
        public string type { get; set; }
        public List<List<List<double>>> coordinates { get; set; }
    }

    public class FeatureClass
    {
        public string type { get; set; }
        public PropertiesClass properties { get; set; }
        public GeometryClass geometry { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public List<FeatureClass> features { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogLoadJSON = new OpenFileDialog();
            openFileDialogLoadJSON.Filter = "JavaScript Object Notation (JSON) | *.json";
            
            if (openFileDialogLoadJSON.ShowDialog() == DialogResult.OK)
            {
                string strFilename = openFileDialogLoadJSON.FileName;
                textBoxLoadJSON.Text = strFilename;                
            }

            //Call JSON function
            string fileJSON = File.ReadAllText(textBoxLoadJSON.Text);
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(fileJSON);

            int i = 0;

            foreach (var featureCount in rootObject.features)
            {
                //Console.WriteLine(i);
                foreach (var coord in rootObject.features[i].geometry.coordinates[0])
                {
                    Console.WriteLine("{0},{1}", coord[0], coord[1]);
                }
                i++;
            }

            
        }

        private void buttonExportFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialogExportFolder = new FolderBrowserDialog();

            if (folderBrowserDialogExportFolder.ShowDialog() == DialogResult.OK)
            {
                string strFoldername = folderBrowserDialogExportFolder.SelectedPath;
                textBoxExportFolder.Text = strFoldername;
            }
        }

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogLoadCSV = new OpenFileDialog();
            openFileDialogLoadCSV.Filter = "Comma Separated Value (CSV) | *.csv";

            if(openFileDialogLoadCSV.ShowDialog() == DialogResult.OK)
            {
                string strFilename = openFileDialogLoadCSV.FileName;
                textBoxLoadCSV.Text = strFilename;
            }

            //Call CSV function
        }
    }
}
