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

            loadJSON();
        }

        private void loadJSON()
        {
            DataTable DataTableTerritory = null;
            DataTableTerritory = new DataTable();
            DataColumn DataColumnTerritory = new DataColumn("Postcodes", typeof(string));
            DataTableTerritory.Columns.Add(DataColumnTerritory);

            string fileJSON = File.ReadAllText(textBoxLoadJSON.Text);
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(fileJSON);

            int RowIndex = 0;

            foreach (var featureCount in rootObject.features)
            {
                Console.WriteLine(RowIndex);
                string mapcoordinates = "";

                DataRow DataRowTerritory = DataTableTerritory.NewRow();
                
                foreach (var coord in rootObject.features[RowIndex].geometry.coordinates[0])
                {
                    //Comma delimit postcodes
                    mapcoordinates = mapcoordinates + coord[0] + "," + coord[1] + ",";
                }

                mapcoordinates = mapcoordinates.Substring(0, mapcoordinates.Length - 1);
                
                DataRowTerritory[0] = mapcoordinates.ToString();
                DataTableTerritory.Rows.Add(DataRowTerritory);
                //Console.WriteLine(DataTableTerritory.Rows[0].ItemArray[0].ToString());

                RowIndex++;
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