using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFirst
{
    public partial class UploadMultipleFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_upload_click(object sender, EventArgs e)
        {
            if (fileupload.PostedFile != null && fileupload.PostedFile.ContentLength > 0)
            {
                var count = 0;
                foreach (HttpPostedFile uploadedfile in fileupload.PostedFiles)
                {
                    string fn = System.IO.Path.GetFileName(uploadedfile.FileName);
                    System.Diagnostics.Debug.Write("File Name : " + fn);
                    string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                    try
                    {
                        fileupload.SaveAs(SaveLocation);
                        count++;
                    }
                    catch (Exception ex)
                    {
                        FileUploadStatus.Text = "error : " + ex.Message;
                    }
                }
                if (count > 0)
                {
                    FileUploadStatus.Text = count + " files has been uploaded.";
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select a file to upload.";
            }
        }
    }
}
