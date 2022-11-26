namespace Arseneau_CrowleyLab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpMultiplier = new System.Windows.Forms.GroupBox();
            this.lblFinalAnswer = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.picCats = new System.Windows.Forms.PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.grpMultiplier.SuspendLayout();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMultiplier
            // 
            this.grpMultiplier.Controls.Add(this.lblFinalAnswer);
            this.grpMultiplier.Controls.Add(this.lblAnswer);
            this.grpMultiplier.Controls.Add(this.lblMultiplier);
            this.grpMultiplier.Controls.Add(this.lblNumber);
            this.grpMultiplier.Controls.Add(this.txtMultiplier);
            this.grpMultiplier.Controls.Add(this.txtNum);
            this.grpMultiplier.Controls.Add(this.btnReset);
            this.grpMultiplier.Controls.Add(this.btnCalculate);
            this.grpMultiplier.Location = new System.Drawing.Point(12, 12);
            this.grpMultiplier.Name = "grpMultiplier";
            this.grpMultiplier.Size = new System.Drawing.Size(270, 307);
            this.grpMultiplier.TabIndex = 0;
            this.grpMultiplier.TabStop = false;
            this.grpMultiplier.Text = "Multiplier";
            // 
            // lblFinalAnswer
            // 
            this.lblFinalAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalAnswer.Location = new System.Drawing.Point(120, 167);
            this.lblFinalAnswer.Name = "lblFinalAnswer";
            this.lblFinalAnswer.Size = new System.Drawing.Size(110, 24);
            this.lblFinalAnswer.TabIndex = 5;
            this.lblFinalAnswer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(19, 175);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(81, 16);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.Location = new System.Drawing.Point(19, 105);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(81, 16);
            this.lblMultiplier.TabIndex = 3;
            this.lblMultiplier.Text = "Multiplier:";
            this.lblMultiplier.Click += new System.EventHandler(this.Multiplier_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(19, 40);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(120, 103);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(110, 23);
            this.txtMultiplier.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(120, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(110, 23);
            this.txtNum.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(145, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 247);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 44);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.lblTopic);
            this.grpInformation.Controls.Add(this.btnExit);
            this.grpInformation.Controls.Add(this.btnHide);
            this.grpInformation.Controls.Add(this.btnData);
            this.grpInformation.Controls.Add(this.btnPicture);
            this.grpInformation.Controls.Add(this.lblInformation);
            this.grpInformation.Controls.Add(this.picCats);
            this.grpInformation.Location = new System.Drawing.Point(303, 12);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(404, 307);
            this.grpInformation.TabIndex = 1;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // lblTopic
            // 
            this.lblTopic.Location = new System.Drawing.Point(150, 13);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(115, 22);
            this.lblTopic.TabIndex = 7;
            this.lblTopic.Text = "Chester and Ritz";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(205, 247);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(87, 44);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(107, 247);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(90, 44);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(6, 247);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(93, 44);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // picCats
            // 
            this.picCats.Image = ((System.Drawing.Image)(resources.GetObject("picCats.Image")));
            this.picCats.Location = new System.Drawing.Point(22, 35);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(366, 193);
            this.picCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCats.TabIndex = 6;
            this.picCats.TabStop = false;
            this.picCats.Visible = false;
            this.picCats.Click += new System.EventHandler(this.picCats_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.Location = new System.Drawing.Point(22, 35);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(366, 193);
            this.lblInformation.TabIndex = 5;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            this.lblInformation.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpMultiplier);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "Lab 2 by Tyler Arseneau-Crowley";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMultiplier.ResumeLayout(false);
            this.grpMultiplier.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMultiplier;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinalAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox picCats;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblTopic;
    }
}

