namespace Fahrplan
{
    partial class Form2
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
            this.dGResultate = new System.Windows.Forms.DataGridView();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGResultate)).BeginInit();
            this.SuspendLayout();
            // 
            // dGResultate
            // 
            this.dGResultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGResultate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nach,
            this.Ab});
            this.dGResultate.Location = new System.Drawing.Point(12, 74);
            this.dGResultate.Name = "dGResultate";
            this.dGResultate.Size = new System.Drawing.Size(300, 241);
            this.dGResultate.TabIndex = 0;
            this.dGResultate.TabStop = false;
            // 
            // Nach
            // 
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            // 
            // Ab
            // 
            this.Ab.HeaderText = "Ab";
            this.Ab.Name = "Ab";
            // 
            // cVon
            // 
            this.cVon.FormattingEnabled = true;
            this.cVon.Location = new System.Drawing.Point(47, 30);
            this.cVon.Name = "cVon";
            this.cVon.Size = new System.Drawing.Size(162, 21);
            this.cVon.TabIndex = 0;
            this.cVon.DropDown += new System.EventHandler(this.cVon_DropDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von:";
            // 
            // bSuchen
            // 
            this.bSuchen.Location = new System.Drawing.Point(237, 28);
            this.bSuchen.Name = "bSuchen";
            this.bSuchen.Size = new System.Drawing.Size(75, 23);
            this.bSuchen.TabIndex = 1;
            this.bSuchen.Text = "Suchen";
            this.bSuchen.UseVisualStyleBackColor = true;
            this.bSuchen.Click += new System.EventHandler(this.bSuchen_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.bSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 327);
            this.Controls.Add(this.bSuchen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cVon);
            this.Controls.Add(this.dGResultate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dGResultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGResultate;
        private System.Windows.Forms.ComboBox cVon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSuchen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ab;
    }
}