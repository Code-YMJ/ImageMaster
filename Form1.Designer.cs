
namespace ImageMaster
{
    partial class frmImageMaster
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lsbPicture = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbGray = new System.Windows.Forms.CheckBox();
            this.cbUseTreshold = new System.Windows.Forms.CheckBox();
            this.cbUseEdgeFilter = new System.Windows.Forms.CheckBox();
            this.cbUseMorphology = new System.Windows.Forms.CheckBox();
            this.pbOrigin = new System.Windows.Forms.PictureBox();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.tbRV = new System.Windows.Forms.TextBox();
            this.cbThresholdFlag = new System.Windows.Forms.ComboBox();
            this.lbThreshold = new System.Windows.Forms.Label();
            this.lbRV = new System.Windows.Forms.Label();
            this.lbFlag = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btnConvertImage = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEdge = new System.Windows.Forms.Label();
            this.cbEdgeFilter = new System.Windows.Forms.ComboBox();
            this.lbMorphology = new System.Windows.Forms.Label();
            this.cbMorphology = new System.Windows.Forms.ComboBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.ofdAddImage = new System.Windows.Forms.OpenFileDialog();
            this.fbdAddImages = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdSaveImagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveOne = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEdgeThr1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEdgeThr2 = new System.Windows.Forms.TextBox();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(494, 13);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(183, 48);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lsbPicture
            // 
            this.lsbPicture.FormattingEnabled = true;
            this.lsbPicture.Location = new System.Drawing.Point(14, 13);
            this.lsbPicture.Name = "lsbPicture";
            this.lsbPicture.ScrollAlwaysVisible = true;
            this.lsbPicture.Size = new System.Drawing.Size(463, 511);
            this.lsbPicture.TabIndex = 1;
            this.lsbPicture.SelectedIndexChanged += new System.EventHandler(this.lsbPicture_SelectedIndexChanged);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(494, 67);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(183, 48);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(494, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 48);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbGray
            // 
            this.cbGray.AutoSize = true;
            this.cbGray.Location = new System.Drawing.Point(694, 352);
            this.cbGray.Name = "cbGray";
            this.cbGray.Size = new System.Drawing.Size(57, 18);
            this.cbGray.TabIndex = 5;
            this.cbGray.Text = "Gray";
            this.cbGray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbGray.UseVisualStyleBackColor = true;
            // 
            // cbUseTreshold
            // 
            this.cbUseTreshold.AutoSize = true;
            this.cbUseTreshold.Location = new System.Drawing.Point(768, 352);
            this.cbUseTreshold.Name = "cbUseTreshold";
            this.cbUseTreshold.Size = new System.Drawing.Size(108, 18);
            this.cbUseTreshold.TabIndex = 6;
            this.cbUseTreshold.Text = "UseTreshold";
            this.cbUseTreshold.UseVisualStyleBackColor = true;
            // 
            // cbUseEdgeFilter
            // 
            this.cbUseEdgeFilter.AutoSize = true;
            this.cbUseEdgeFilter.Location = new System.Drawing.Point(888, 352);
            this.cbUseEdgeFilter.Name = "cbUseEdgeFilter";
            this.cbUseEdgeFilter.Size = new System.Drawing.Size(90, 18);
            this.cbUseEdgeFilter.TabIndex = 7;
            this.cbUseEdgeFilter.Text = "Use Edge";
            this.cbUseEdgeFilter.UseVisualStyleBackColor = true;
            // 
            // cbUseMorphology
            // 
            this.cbUseMorphology.AutoSize = true;
            this.cbUseMorphology.Location = new System.Drawing.Point(1005, 352);
            this.cbUseMorphology.Name = "cbUseMorphology";
            this.cbUseMorphology.Size = new System.Drawing.Size(135, 18);
            this.cbUseMorphology.TabIndex = 8;
            this.cbUseMorphology.Text = "Use Morphology";
            this.cbUseMorphology.UseVisualStyleBackColor = true;
            // 
            // pbOrigin
            // 
            this.pbOrigin.Location = new System.Drawing.Point(694, 13);
            this.pbOrigin.Name = "pbOrigin";
            this.pbOrigin.Size = new System.Drawing.Size(480, 320);
            this.pbOrigin.TabIndex = 11;
            this.pbOrigin.TabStop = false;
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(1023, 388);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(80, 23);
            this.tbThreshold.TabIndex = 12;
            // 
            // tbRV
            // 
            this.tbRV.Location = new System.Drawing.Point(1140, 388);
            this.tbRV.Name = "tbRV";
            this.tbRV.Size = new System.Drawing.Size(59, 23);
            this.tbRV.TabIndex = 13;
            // 
            // cbThresholdFlag
            // 
            this.cbThresholdFlag.FormattingEnabled = true;
            this.cbThresholdFlag.Location = new System.Drawing.Point(808, 390);
            this.cbThresholdFlag.Name = "cbThresholdFlag";
            this.cbThresholdFlag.Size = new System.Drawing.Size(132, 21);
            this.cbThresholdFlag.TabIndex = 14;
            // 
            // lbThreshold
            // 
            this.lbThreshold.AutoSize = true;
            this.lbThreshold.Location = new System.Drawing.Point(946, 391);
            this.lbThreshold.Name = "lbThreshold";
            this.lbThreshold.Size = new System.Drawing.Size(71, 14);
            this.lbThreshold.TabIndex = 15;
            this.lbThreshold.Text = "Threshold";
            // 
            // lbRV
            // 
            this.lbRV.AutoSize = true;
            this.lbRV.Location = new System.Drawing.Point(1109, 391);
            this.lbRV.Name = "lbRV";
            this.lbRV.Size = new System.Drawing.Size(25, 14);
            this.lbRV.TabIndex = 16;
            this.lbRV.Text = "RV";
            // 
            // lbFlag
            // 
            this.lbFlag.AutoSize = true;
            this.lbFlag.Location = new System.Drawing.Point(693, 393);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.Size = new System.Drawing.Size(109, 14);
            this.lbFlag.TabIndex = 17;
            this.lbFlag.Text = "Threshord Type";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(1362, 364);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(358, 23);
            this.tbSavePath.TabIndex = 18;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(1253, 12);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(480, 320);
            this.pbResult.TabIndex = 19;
            this.pbResult.TabStop = false;
            // 
            // btnConvertImage
            // 
            this.btnConvertImage.Location = new System.Drawing.Point(947, 554);
            this.btnConvertImage.Name = "btnConvertImage";
            this.btnConvertImage.Size = new System.Drawing.Size(227, 48);
            this.btnConvertImage.TabIndex = 20;
            this.btnConvertImage.Text = "Convert";
            this.btnConvertImage.UseVisualStyleBackColor = true;
            this.btnConvertImage.Click += new System.EventHandler(this.btnConvertImage_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(1253, 435);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(203, 48);
            this.btnSavePath.TabIndex = 21;
            this.btnSavePath.Text = "Set Save Path";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1250, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Save Folder";
            // 
            // lbEdge
            // 
            this.lbEdge.AutoSize = true;
            this.lbEdge.Location = new System.Drawing.Point(693, 453);
            this.lbEdge.Name = "lbEdge";
            this.lbEdge.Size = new System.Drawing.Size(75, 14);
            this.lbEdge.TabIndex = 24;
            this.lbEdge.Text = "Edge Filter";
            // 
            // cbEdgeFilter
            // 
            this.cbEdgeFilter.FormattingEnabled = true;
            this.cbEdgeFilter.Location = new System.Drawing.Point(808, 448);
            this.cbEdgeFilter.Name = "cbEdgeFilter";
            this.cbEdgeFilter.Size = new System.Drawing.Size(132, 21);
            this.cbEdgeFilter.TabIndex = 23;
            // 
            // lbMorphology
            // 
            this.lbMorphology.AutoSize = true;
            this.lbMorphology.Location = new System.Drawing.Point(693, 510);
            this.lbMorphology.Name = "lbMorphology";
            this.lbMorphology.Size = new System.Drawing.Size(85, 14);
            this.lbMorphology.TabIndex = 26;
            this.lbMorphology.Text = "Morphology";
            // 
            // cbMorphology
            // 
            this.cbMorphology.FormattingEnabled = true;
            this.cbMorphology.Location = new System.Drawing.Point(808, 507);
            this.cbMorphology.Name = "cbMorphology";
            this.cbMorphology.Size = new System.Drawing.Size(132, 21);
            this.cbMorphology.TabIndex = 25;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(1253, 492);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(467, 48);
            this.btnSaveAll.TabIndex = 27;
            this.btnSaveAll.Text = "Save ALL";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveOne
            // 
            this.btnSaveOne.Location = new System.Drawing.Point(1517, 435);
            this.btnSaveOne.Name = "btnSaveOne";
            this.btnSaveOne.Size = new System.Drawing.Size(203, 48);
            this.btnSaveOne.TabIndex = 28;
            this.btnSaveOne.Text = "Save One";
            this.btnSaveOne.UseVisualStyleBackColor = true;
            this.btnSaveOne.Click += new System.EventHandler(this.btnSaveOne_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(694, 554);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(227, 48);
            this.btnClearImage.TabIndex = 29;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(958, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thr1";
            // 
            // tbEdgeThr1
            // 
            this.tbEdgeThr1.Location = new System.Drawing.Point(1023, 448);
            this.tbEdgeThr1.Name = "tbEdgeThr1";
            this.tbEdgeThr1.Size = new System.Drawing.Size(80, 23);
            this.tbEdgeThr1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1105, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Thr2";
            // 
            // tbEdgeThr2
            // 
            this.tbEdgeThr2.Location = new System.Drawing.Point(1140, 450);
            this.tbEdgeThr2.Name = "tbEdgeThr2";
            this.tbEdgeThr2.Size = new System.Drawing.Size(59, 23);
            this.tbEdgeThr2.TabIndex = 32;
            // 
            // cbExtension
            // 
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(1368, 404);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(132, 21);
            this.cbExtension.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1250, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Save Extension";
            // 
            // frmImageMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEdgeThr2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEdgeThr1);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.btnSaveOne);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.lbMorphology);
            this.Controls.Add(this.cbMorphology);
            this.Controls.Add(this.lbEdge);
            this.Controls.Add(this.cbEdgeFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnConvertImage);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.lbFlag);
            this.Controls.Add(this.lbRV);
            this.Controls.Add(this.lbThreshold);
            this.Controls.Add(this.cbThresholdFlag);
            this.Controls.Add(this.tbRV);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.pbOrigin);
            this.Controls.Add(this.cbUseMorphology);
            this.Controls.Add(this.cbUseEdgeFilter);
            this.Controls.Add(this.cbUseTreshold);
            this.Controls.Add(this.cbGray);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lsbPicture);
            this.Controls.Add(this.btnAddFolder);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.Name = "frmImageMaster";
            this.Text = "Image Master";
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ListBox lsbPicture;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbGray;
        private System.Windows.Forms.CheckBox cbUseTreshold;
        private System.Windows.Forms.CheckBox cbUseEdgeFilter;
        private System.Windows.Forms.CheckBox cbUseMorphology;
        private System.Windows.Forms.PictureBox pbOrigin;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.TextBox tbRV;
        private System.Windows.Forms.ComboBox cbThresholdFlag;
        private System.Windows.Forms.Label lbThreshold;
        private System.Windows.Forms.Label lbRV;
        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnConvertImage;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEdge;
        private System.Windows.Forms.ComboBox cbEdgeFilter;
        private System.Windows.Forms.Label lbMorphology;
        private System.Windows.Forms.ComboBox cbMorphology;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.OpenFileDialog ofdAddImage;
        private System.Windows.Forms.FolderBrowserDialog fbdAddImages;
        private System.Windows.Forms.FolderBrowserDialog fbdSaveImagePath;
        private System.Windows.Forms.Button btnSaveOne;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEdgeThr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEdgeThr2;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

