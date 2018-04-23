Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#using"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
' ...
#End Region ' #using
Imports System.Reflection
Imports System.IO
Imports System.Resources

Namespace InlinePictures
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.LoadDocument("Texts\Lorem.rtf", DocumentFormat.Rtf)
		End Sub

Private Sub btnFromImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromImage.Click
'#Region "#fromimage"

Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
Dim imageToInsert As Image = imageCollection1.Images(3)
richEditControl1.Document.InsertImage(pos, imageToInsert)

'#End Region ' #fromimage
End Sub

Private Sub btnFromFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromFile.Click
'#Region "#fromfile"
Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition

Dim dialog As New OpenFileDialog()
dialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*"
dialog.FilterIndex = 1
dialog.RestoreDirectory = True

If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
	Dim imageToInsert As String = dialog.FileName
	richEditControl1.Document.InsertImage(pos, DocumentImageSource.FromFile(imageToInsert))
End If
'#End Region ' #fromfile

End Sub

Private Sub btnFromStream_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromStream.Click
'#Region "#fromstream"
Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
Dim imageToInsert As String = "information.png"
Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

Dim imageStream As Stream = a.GetManifestResourceStream("Resources." & imageToInsert)
richEditControl1.Document.InsertImage(pos, DocumentImageSource.FromStream(imageStream))
'#End Region ' #fromstream
End Sub

Private Sub btnScaleDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScaleDown.Click
'#Region "#scaledown"
richEditControl1.Document.Unit = DevExpress.XtraRichEdit.DocumentUnit.Millimeter
Dim images As DocumentImageCollection = richEditControl1.Document.GetImages(richEditControl1.Document.Range)

For i As Integer = 0 To images.Count - 1
	If images(i).Size.Width > 50 Then
		images(i).ScaleX /= 2
		images(i).ScaleY /= 2
	End If
Next i
'#End Region ' #scaledown
End Sub

Private Sub btnFromUri_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromUri.Click
'#Region "#fromuri"
Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
Dim imageUri As String = "http://www.devexpress.com/App_Themes/DX/Common/footer_logo.gif"
richEditControl1.Document.InsertImage(pos, DocumentImageSource.FromUri(imageUri,richEditControl1))
'#End Region ' #fromuri
End Sub
	End Class
End Namespace