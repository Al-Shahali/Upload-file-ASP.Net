<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Browser Upload multiple files</p>
            <asp:FileUpload ID="fileupload" runat="server" AllowMultiple="true" />
        </div>
        <asp:Button ID="btnUpload" runat="server" Text="upload" OnClick="Btn_upload_click" />
    </form>
    <asp:Label runat="server" ID="FileUploadStatus"></asp:Label>
</body>
</html>
