Imports Microsoft.VisualBasic
Imports System
Namespace InlinePictures
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnFromUri = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFromStream = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFromFile = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFromImage = New DevExpress.XtraEditors.SimpleButton()
			Me.btnScaleDown = New DevExpress.XtraEditors.SimpleButton()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 40)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(679, 409)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnFromUri)
			Me.panelControl1.Controls.Add(Me.btnFromStream)
			Me.panelControl1.Controls.Add(Me.btnFromFile)
			Me.panelControl1.Controls.Add(Me.btnFromImage)
			Me.panelControl1.Controls.Add(Me.btnScaleDown)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(679, 40)
			Me.panelControl1.TabIndex = 1
			' 
			' btnFromUri
			' 
			Me.btnFromUri.Location = New System.Drawing.Point(543, 5)
			Me.btnFromUri.Name = "btnFromUri"
			Me.btnFromUri.Size = New System.Drawing.Size(94, 23)
			Me.btnFromUri.TabIndex = 4
			Me.btnFromUri.Text = "Load From Uri"
'			Me.btnFromUri.Click += New System.EventHandler(Me.btnFromUri_Click);
			' 
			' btnFromStream
			' 
			Me.btnFromStream.Location = New System.Drawing.Point(435, 5)
			Me.btnFromStream.Name = "btnFromStream"
			Me.btnFromStream.Size = New System.Drawing.Size(94, 23)
			Me.btnFromStream.TabIndex = 3
			Me.btnFromStream.Text = "Load From Stream"
'			Me.btnFromStream.Click += New System.EventHandler(Me.btnFromStream_Click);
			' 
			' btnFromFile
			' 
			Me.btnFromFile.Location = New System.Drawing.Point(327, 5)
			Me.btnFromFile.Name = "btnFromFile"
			Me.btnFromFile.Size = New System.Drawing.Size(94, 23)
			Me.btnFromFile.TabIndex = 2
			Me.btnFromFile.Text = "Load From File"
'			Me.btnFromFile.Click += New System.EventHandler(Me.btnFromFile_Click);
			' 
			' btnFromImage
			' 
			Me.btnFromImage.Location = New System.Drawing.Point(219, 5)
			Me.btnFromImage.Name = "btnFromImage"
			Me.btnFromImage.Size = New System.Drawing.Size(94, 23)
			Me.btnFromImage.TabIndex = 1
			Me.btnFromImage.Text = "Load from Image"
'			Me.btnFromImage.Click += New System.EventHandler(Me.btnFromImage_Click);
			' 
			' btnScaleDown
			' 
			Me.btnScaleDown.Location = New System.Drawing.Point(12, 5)
			Me.btnScaleDown.Name = "btnScaleDown"
			Me.btnScaleDown.Size = New System.Drawing.Size(108, 23)
			Me.btnScaleDown.TabIndex = 0
			Me.btnScaleDown.Text = "Scale Down Pictures"
'			Me.btnScaleDown.Click += New System.EventHandler(Me.btnScaleDown_Click);
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(11, 11)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(679, 449)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnFromFile As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnFromImage As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnScaleDown As DevExpress.XtraEditors.SimpleButton
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private WithEvents btnFromStream As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnFromUri As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

