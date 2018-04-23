using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #using
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
// ...
#endregion #using
using System.Reflection;
using System.IO;
using System.Resources;

namespace InlinePictures {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            richEditControl1.LoadDocument("Texts\\Lorem.rtf", DocumentFormat.Rtf);
        }

private void btnFromImage_Click(object sender, EventArgs e) {
#region #fromimage

DocumentPosition pos = richEditControl1.Document.CaretPosition;
Image imageToInsert = imageCollection1.Images[3];
richEditControl1.Document.Images.Insert(pos, imageToInsert);

#endregion #fromimage
}

private void btnFromFile_Click(object sender, EventArgs e) {
#region #fromfile
DocumentPosition pos = richEditControl1.Document.CaretPosition;

OpenFileDialog dialog = new OpenFileDialog();
dialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
dialog.FilterIndex = 1;
dialog.RestoreDirectory = true;

if(dialog.ShowDialog() == DialogResult.OK) {
    string imageToInsert = dialog.FileName;
    richEditControl1.Document.Images.Insert(pos, 
        DocumentImageSource.FromFile(imageToInsert));
}
#endregion #fromfile

}

private void btnFromStream_Click(object sender, EventArgs e) {
#region #fromstream
DocumentPosition pos = richEditControl1.Document.CaretPosition;
string imageToInsert = "information.png";
Assembly a = Assembly.GetExecutingAssembly();

Stream imageStream = a.GetManifestResourceStream("InlinePictures.Resources." + imageToInsert);
richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromStream(imageStream));
#endregion #fromstream
}

private void btnScaleDown_Click(object sender, EventArgs e) {
#region #scaledown
richEditControl1.Document.Unit = 
    DevExpress.Office.DocumentUnit.Millimeter;
ReadOnlyDocumentImageCollection images =
    richEditControl1.Document.Images.Get(richEditControl1.Document.Range);

for(int i = 0; i < images.Count; i++) {
    if(images[i].Size.Width > 50) {
        images[i].ScaleX /= 2;
        images[i].ScaleY /= 2;
    }
}
#endregion #scaledown
}

private void btnFromUri_Click(object sender, EventArgs e) {
#region #fromuri
DocumentPosition pos = richEditControl1.Document.CaretPosition;
string imageUri = "http://www.devexpress.com/App_Themes/DX/Common/footer_logo.gif";
richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromUri(imageUri, richEditControl1));
#endregion #fromuri
}
    }
}