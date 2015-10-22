using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace FileConverter
{
    public partial class FTPManagerForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            //Create a New WebClient.
            WebClient request = new WebClient();

            //setup our credentials
            request.Credentials = new NetworkCredential(this.txtUsername.Text, this.txtPassword.Text);

            //Download the data into a Byte array
            byte[] fileData = request.DownloadData(this.txtAddress.Text + "/" + this.txtFileToDownload.Text); 

            //Create a filestream that we will write the byte array to.
            FileStream file = File.Create(this.txtDownloadPath.Text + "\\" + this.txtFileToDownload.Text);

            //Write the full byte array to the file. 
            file.Write(fileData, 0, fileData.Length);

            //Close The file So other processes can AccessDataSource it. 
            file.Close();

            //MessageBox.Show("Download Complete");

        }
    }
}