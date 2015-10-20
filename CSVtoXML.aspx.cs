using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Data;

namespace FileConverter
{
    public partial class ReadCVS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string Extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];


            //Substring everything before the period, then add ".xml" at the end of the ExportedFileName
            string ExportPath = @"C:\temp\temp\";
            string ExportFileName = "ExportDT.xml";

            string FilePath = Server.MapPath(FolderPath + FileName);

            FileUpload1.SaveAs(FilePath);
            csvObjects csvO = new csvObjects();
            
            //ImportToGrid(FilePath, Extension, rbHDR.SelectedItem.Text);
            DataTable dt = csvO.ImportCsvToDataTable(FilePath, Extension, rbHDR.SelectedItem.Text);

            csvO.ExportDataTableToXML(dt, ExportPath, ExportFileName);

            FilePathHiddenField.Value = FilePath;
            ExtensionHiddenField.Value = Extension;
            IsHDRHiddenField.Value = rbHDR.SelectedItem.Text;

            GridView1.DataSource = dt;
            GridView1.DataBind();

           // ExportHelpers.GlobalVar.filePath = FilePath;
           // ExportHelpers.GlobalVar.extension = Extension;
           // ExportHelpers.GlobalVar.isHDRHiddenField = rbHDR.SelectedItem.Text;
        }
    }
}