namespace InlinePictures {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFromUri = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromStream = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnScaleDown = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 40);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(679, 409);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFromUri);
            this.panelControl1.Controls.Add(this.btnFromStream);
            this.panelControl1.Controls.Add(this.btnFromFile);
            this.panelControl1.Controls.Add(this.btnFromImage);
            this.panelControl1.Controls.Add(this.btnScaleDown);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // btnFromUri
            // 
            this.btnFromUri.Location = new System.Drawing.Point(543, 5);
            this.btnFromUri.Name = "btnFromUri";
            this.btnFromUri.Size = new System.Drawing.Size(94, 23);
            this.btnFromUri.TabIndex = 4;
            this.btnFromUri.Text = "Load From Uri";
            this.btnFromUri.Click += new System.EventHandler(this.btnFromUri_Click);
            // 
            // btnFromStream
            // 
            this.btnFromStream.Location = new System.Drawing.Point(435, 5);
            this.btnFromStream.Name = "btnFromStream";
            this.btnFromStream.Size = new System.Drawing.Size(94, 23);
            this.btnFromStream.TabIndex = 3;
            this.btnFromStream.Text = "Load From Stream";
            this.btnFromStream.Click += new System.EventHandler(this.btnFromStream_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.Location = new System.Drawing.Point(327, 5);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(94, 23);
            this.btnFromFile.TabIndex = 2;
            this.btnFromFile.Text = "Load From File";
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // btnFromImage
            // 
            this.btnFromImage.Location = new System.Drawing.Point(219, 5);
            this.btnFromImage.Name = "btnFromImage";
            this.btnFromImage.Size = new System.Drawing.Size(94, 23);
            this.btnFromImage.TabIndex = 1;
            this.btnFromImage.Text = "Load from Image";
            this.btnFromImage.Click += new System.EventHandler(this.btnFromImage_Click);
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(12, 5);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(108, 23);
            this.btnScaleDown.TabIndex = 0;
            this.btnScaleDown.Text = "Scale Down Pictures";
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(11, 11);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 449);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFromFile;
        private DevExpress.XtraEditors.SimpleButton btnFromImage;
        private DevExpress.XtraEditors.SimpleButton btnScaleDown;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnFromStream;
        private DevExpress.XtraEditors.SimpleButton btnFromUri;
    }
}

